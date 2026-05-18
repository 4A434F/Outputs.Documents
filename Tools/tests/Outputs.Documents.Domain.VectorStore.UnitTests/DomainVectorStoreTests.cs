using Outputs.Documents.Domain.VectorStore.Alignment;
using Outputs.Documents.Domain.VectorStore.Descriptors;
using Outputs.Documents.Domain.VectorStore.Records;
using Outputs.Documents.Domain.VectorStore.UnitTests.Support;

namespace Outputs.Documents.Domain.VectorStore.UnitTests;

public sealed class DomainVectorStoreTests
{
    private const string Model = "test-embedding-model";

    [Fact]
    public void Describe_ReturnsDescriptorsFromDomainSearchAttributes()
    {
        using var scope = StoreScope.Create();

        var descriptors = scope.Store.Describe(typeof(User));

        Assert.Contains(descriptors, descriptor =>
            descriptor.Id == EntityId<User>() &&
            descriptor.Kind == EmbeddingRecordKinds.Entity &&
            descriptor.Name == "User");
        Assert.Contains(descriptors, descriptor =>
            descriptor.Id == PropertyId<User>(nameof(User.UserName)) &&
            descriptor.Kind == EmbeddingRecordKinds.Property &&
            descriptor.Name == "User name" &&
            descriptor.Aliases.Contains("login"));
    }

    [Fact]
    public async Task UpsertAndGetAsync_RoundTripsRecordBuiltFromDomainType()
    {
        using var scope = StoreScope.Create();
        var embeddings = CreateEmbeddings<User>(descriptor => descriptor.Id switch
        {
            var id when id == PropertyId<User>(nameof(User.UserName)) => [1, 0, 0],
            var id when id == PropertyId<User>(nameof(User.Email)) => [0, 1, 0],
            _ => [0, 0, 1]
        });

        await scope.Store.UpsertAsync(Model, typeof(User), embeddings);

        var stored = await scope.Store.GetAsync(Model, PropertyId<User>(nameof(User.UserName)));

        Assert.NotNull(stored);
        Assert.Equal("User name", stored.Name);
        Assert.Contains("login", stored.Aliases);
        Assert.Contains("Domain Property: User name.", stored.Text);
        Assert.Equal([1, 0, 0], stored.Embedding);
    }

    [Fact]
    public async Task GetAsync_ReturnsNullForMissingId()
    {
        using var scope = StoreScope.Create();

        var stored = await scope.Store.GetAsync(Model, "missing");

        Assert.Null(stored);
    }

    [Fact]
    public async Task ReadOperations_DoNotCreateDatabaseForUnknownModel()
    {
        using var scope = StoreScope.Create();

        var stored = await scope.Store.GetAsync(Model, "missing");
        var records = await scope.Store.ListAsync(Model);
        var exactResults = await scope.Store.ExactSearchAsync(Model, "user");
        var vectorResults = await scope.Store.VectorSearchAsync(Model, [1, 0]);

        Assert.Null(stored);
        Assert.Empty(records);
        Assert.Empty(exactResults);
        Assert.Empty(vectorResults);
        Assert.False(Directory.Exists(scope.DirectoryPath));
    }

    [Fact]
    public async Task ListModelsAsync_ReturnsModelNamesFromCreatedDatabases()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertAsync(Model, typeof(User), CreateEmbeddings<User>(_ => [1, 0]));
        await scope.Store.UpsertAsync("another-model", typeof(Address), CreateEmbeddings<Address>(_ => [0, 1]));

        var models = await scope.Store.ListModelsAsync();

        Assert.Equal(["another-model", Model], models);
    }

    [Fact]
    public async Task ListAsync_CanFilterByKind()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertAsync(Model, typeof(User), CreateEmbeddings<User>(_ => [1, 0]));

        var properties = await scope.Store.ListAsync(Model, EmbeddingRecordKinds.Property);

        Assert.Equal(2, properties.Count);
        Assert.All(properties, record => Assert.Equal(EmbeddingRecordKinds.Property, record.Kind));
    }

    [Fact]
    public async Task DeleteByDeclarationAsync_RemovesMatchingRecords()
    {
        using var scope = StoreScope.Create();
        await scope.Store.UpsertAsync(Model, typeof(User), CreateEmbeddings<User>(_ => [1, 0]));

        await scope.Store.DeleteByDeclarationAsync(
            Model,
            EmbeddingRecordKinds.Property,
            Declaration<User>(nameof(User.UserName)));

        var records = await scope.Store.ListAsync(Model, EmbeddingRecordKinds.Property);

        var record = Assert.Single(records);
        Assert.Equal(PropertyId<User>(nameof(User.Email)), record.Id);
    }

    [Fact]
    public async Task ExactSearchAsync_MatchesNameAndAlias()
    {
        using var scope = StoreScope.Create();
        await scope.Store.UpsertAsync(Model, typeof(User), CreateEmbeddings<User>(_ => [1, 0]));

        var results = await scope.Store.ExactSearchAsync(Model, "login");

        var result = Assert.Single(results);
        Assert.Equal(PropertyId<User>(nameof(User.UserName)), result.Record.Id);
        Assert.Contains("Alias", result.MatchKind);
    }

    [Fact]
    public async Task VectorSearchAsync_ReturnsClosestVectors()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertManyAsync(
            Model,
            [
                new DomainEmbeddingRegistration(typeof(Address), CreateEmbeddings<Address>(_ => [1, 0])),
                new DomainEmbeddingRegistration(typeof(Payment), CreateEmbeddings<Payment>(_ => [0, 1]))
            ]);

        var results = await scope.Store.VectorSearchAsync(Model, [0.95f, 0.05f], limit: 2);

        Assert.Equal(EntityId<Address>(), results[0].Record.Id);
        Assert.True(results[0].Similarity > results[1].Similarity);
    }

    [Fact]
    public async Task VectorSearchAsync_CanFilterByKind()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertAsync(
            Model,
            typeof(User),
            CreateEmbeddings<User>(descriptor => descriptor.Id == PropertyId<User>(nameof(User.UserName))
                ? [1, 0]
                : [0, 1]));

        var results = await scope.Store.VectorSearchAsync(
            Model,
            [1, 0],
            limit: 1,
            kind: EmbeddingRecordKinds.Property);

        var result = Assert.Single(results);
        Assert.Equal(PropertyId<User>(nameof(User.UserName)), result.Record.Id);
    }

    [Fact]
    public async Task HybridSearchAsync_CombinesExactAndVectorMatches()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertAsync(
            Model,
            typeof(User),
            CreateEmbeddings<User>(descriptor => descriptor.Id == PropertyId<User>(nameof(User.UserName))
                ? [0, 1]
                : [1, 0]));

        var results = await scope.Store.HybridSearchAsync(Model, "login", [1, 0], limit: 2);

        Assert.Equal(PropertyId<User>(nameof(User.UserName)), results[0].Record.Id);
        Assert.Contains("Alias", results[0].MatchKinds);
        Assert.Contains(results, result => result.MatchKinds.Contains("Vector"));
    }

    [Fact]
    public async Task SaveAlignmentSetAsync_AndCheckAlignmentAsync_ReturnsSimilarity()
    {
        using var scope = StoreScope.Create();
        var baseline = CreateAlignmentSet();

        await scope.Store.SaveAlignmentSetAsync(Model, baseline);

        var check = CreateAlignmentSet();
        var results = await scope.Store.CheckAlignmentAsync(Model, check);

        Assert.All(results, result =>
        {
            Assert.True(result.IsAligned);
            Assert.Equal(1, result.Similarity, precision: 6);
        });
    }

    [Fact]
    public async Task CheckAlignmentAsync_FlagsMisalignedRecord()
    {
        using var scope = StoreScope.Create();
        var baseline = CreateAlignmentSet();

        await scope.Store.SaveAlignmentSetAsync(Model, baseline);

        var check = CreateAlignmentSet()
            .Select(record => record.Key == "address"
                ? record with { Embedding = [0, 1] }
                : record)
            .ToArray();

        var results = await scope.Store.CheckAlignmentAsync(Model, check, minimumSimilarity: 0.98);

        var address = Assert.Single(results, result => result.Key == "address");
        Assert.False(address.IsAligned);
    }

    [Fact]
    public async Task SaveAlignmentSetAsync_RequiresFixedAlignmentPromptKeys()
    {
        using var scope = StoreScope.Create();
        var baseline = CreateAlignmentSet()
            .Where(embedding => embedding.Key != "payment")
            .Append(new AlignmentEmbedding("custom", Model, [0.7f, 0.3f]));

        var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            scope.Store.SaveAlignmentSetAsync(Model, baseline));

        Assert.Contains("fixed keys", exception.Message);
    }

    [Fact]
    public async Task UpsertAsync_ThrowsWhenDomainTypeHasNoSearchMetadata()
    {
        using var scope = StoreScope.Create();

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            scope.Store.UpsertAsync(Model, typeof(UnannotatedDomainType), []));

        Assert.Contains("does not declare any", exception.Message);
    }

    [Fact]
    public async Task UpsertAsync_ThrowsWhenDescriptorEmbeddingIsMissing()
    {
        using var scope = StoreScope.Create();
        var embeddings = CreateEmbeddings<User>(_ => [1, 0])
            .Where(embedding => embedding.DescriptorId != PropertyId<User>(nameof(User.Email)))
            .ToArray();

        var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            scope.Store.UpsertAsync(Model, typeof(User), embeddings));

        Assert.Contains("missing embeddings", exception.Message);
    }

    [Fact]
    public async Task UpsertAsync_ThrowsWhenDescriptorEmbeddingIsUnknown()
    {
        using var scope = StoreScope.Create();
        var embeddings = CreateEmbeddings<User>(_ => [1, 0])
            .Append(new DomainEmbeddingValue("property:Unknown.Property", [1, 0]))
            .ToArray();

        var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            scope.Store.UpsertAsync(Model, typeof(User), embeddings));

        Assert.Contains("unknown descriptors", exception.Message);
    }

    [Fact]
    public async Task UpsertAsync_ThrowsWhenEmbeddingDimensionDoesNotMatchDatabase()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertAsync(Model, typeof(Address), CreateEmbeddings<Address>(_ => [1, 0]));

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            scope.Store.UpsertAsync(Model, typeof(Payment), CreateEmbeddings<Payment>(_ => [1, 0, 0])));

        Assert.Contains("Embedding dimension mismatch", exception.Message);
    }

    private static IReadOnlyList<DomainEmbeddingValue> CreateEmbeddings<TDomain>(
        Func<DomainEmbeddingDescriptor, float[]> createEmbedding)
    {
        return DomainEmbeddingDescriptorReader.Describe(typeof(TDomain))
            .Select(descriptor => new DomainEmbeddingValue(descriptor.Id, createEmbedding(descriptor)))
            .ToArray();
    }

    private static IReadOnlyList<AlignmentEmbedding> CreateAlignmentSet()
    {
        return DomainVectorStoreAlignmentPrompts.All
            .Select(prompt => new AlignmentEmbedding(prompt.Key, Model, prompt.Key switch
            {
                "address" => [1, 0],
                "policy" => [0.9f, 0.1f],
                "footer" => [0, 1],
                "barcode" => [0.1f, 0.9f],
                "payment" => [0.7f, 0.3f],
                _ => throw new InvalidOperationException($"Unexpected alignment prompt '{prompt.Key}'.")
            }))
            .ToArray();
    }

    private static string EntityId<TDomain>()
    {
        return $"entity:{typeof(TDomain).FullName}";
    }

    private static string PropertyId<TDomain>(string propertyName)
    {
        return $"property:{Declaration<TDomain>(propertyName)}";
    }

    private static string Declaration<TDomain>(string propertyName)
    {
        return $"{typeof(TDomain).FullName}.{propertyName}";
    }

    [DomainSearch(
        "User",
        "Application user or customer account.",
        Aliases = ["customer"],
        Tags = ["party"])]
    private sealed record User(
        [property: DomainSearch(
            "User name",
            "Login name used to identify an account.",
            Aliases = ["login", "user name"],
            Tags = ["identifier"])]
        string UserName,
        [property: DomainSearch(
            "Email",
            "Electronic mail contact address.",
            Aliases = ["electronic mail"],
            Tags = ["contact"])]
        string Email);

    [DomainSearch(
        "Address",
        "Postal address block for a recipient or business entity.",
        Aliases = ["morada"],
        Tags = ["location"])]
    private sealed record Address;

    [DomainSearch(
        "Payment",
        "Payment details used to settle a document.",
        Aliases = ["settlement"],
        Tags = ["finance"])]
    private sealed record Payment;

    private sealed record UnannotatedDomainType;
}
