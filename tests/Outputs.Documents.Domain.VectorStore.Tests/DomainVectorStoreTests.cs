using Outputs.Documents.Domain.VectorStore.Alignment;
using Outputs.Documents.Domain.VectorStore.Records;
using Outputs.Documents.Domain.VectorStore.Tests.Support;

namespace Outputs.Documents.Domain.VectorStore.Tests;

public sealed class DomainVectorStoreTests
{
    private const string Model = "test-embedding-model";

    [Fact]
    public async Task UpsertAndGetAsync_RoundTripsRecord()
    {
        using var scope = StoreScope.Create();
        var record = CreateRecord(
            "property:User.UserName",
            EmbeddingRecordKinds.Property,
            "User.UserName",
            "UserName",
            [1, 0, 0],
            aliases: ["user name", "login"]);

        await scope.Store.UpsertAsync(Model, record);

        var stored = await scope.Store.GetAsync(Model, record.Id);

        Assert.NotNull(stored);
        Assert.Equal(record.Id, stored.Id);
        Assert.Equal(record.Name, stored.Name);
        Assert.Equal(record.Aliases, stored.Aliases);
        Assert.Equal(record.Embedding, stored.Embedding);
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

        await scope.Store.UpsertAsync(
            Model,
            CreateRecord("entity:User", EmbeddingRecordKinds.Entity, "User", "User", [1, 0]));

        await scope.Store.UpsertAsync(
            "another-model",
            CreateRecord("entity:Address", EmbeddingRecordKinds.Entity, "Address", "Address", [0, 1], model: "another-model"));

        var models = await scope.Store.ListModelsAsync();

        Assert.Equal(["another-model", Model], models);
    }

    [Fact]
    public async Task ListAsync_CanFilterByKind()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertManyAsync(
            Model,
            [
                CreateRecord("entity:User", EmbeddingRecordKinds.Entity, "User", "User", [1, 0]),
                CreateRecord("property:User.UserName", EmbeddingRecordKinds.Property, "User.UserName", "UserName", [1, 0])
            ]);

        var properties = await scope.Store.ListAsync(Model, EmbeddingRecordKinds.Property);

        var property = Assert.Single(properties);
        Assert.Equal("property:User.UserName", property.Id);
    }

    [Fact]
    public async Task DeleteByDeclarationAsync_RemovesMatchingRecords()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertManyAsync(
            Model,
            [
                CreateRecord("property:User.UserName", EmbeddingRecordKinds.Property, "User.UserName", "UserName", [1, 0]),
                CreateRecord("property:User.Email", EmbeddingRecordKinds.Property, "User.Email", "Email", [0, 1])
            ]);

        await scope.Store.DeleteByDeclarationAsync(Model, EmbeddingRecordKinds.Property, "User.UserName");

        var records = await scope.Store.ListAsync(Model);

        var record = Assert.Single(records);
        Assert.Equal("property:User.Email", record.Id);
    }

    [Fact]
    public async Task ExactSearchAsync_MatchesNameAndAlias()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertManyAsync(
            Model,
            [
                CreateRecord(
                    "property:User.UserName",
                    EmbeddingRecordKinds.Property,
                    "User.UserName",
                    "UserName",
                    [1, 0],
                    aliases: ["user name", "login"]),
                CreateRecord(
                    "property:User.Email",
                    EmbeddingRecordKinds.Property,
                    "User.Email",
                    "Email",
                    [0, 1],
                    aliases: ["electronic mail"])
            ]);

        var results = await scope.Store.ExactSearchAsync(Model, "user name");

        var result = Assert.Single(results);
        Assert.Equal("property:User.UserName", result.Record.Id);
        Assert.Contains("Alias", result.MatchKind);
    }

    [Fact]
    public async Task VectorSearchAsync_ReturnsClosestVectors()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertManyAsync(
            Model,
            [
                CreateRecord("entity:Address", EmbeddingRecordKinds.Entity, "Address", "Address", [1, 0]),
                CreateRecord("entity:Payment", EmbeddingRecordKinds.Entity, "Payment", "Payment", [0, 1])
            ]);

        var results = await scope.Store.VectorSearchAsync(Model, [0.95f, 0.05f], limit: 2);

        Assert.Equal("entity:Address", results[0].Record.Id);
        Assert.True(results[0].Similarity > results[1].Similarity);
    }

    [Fact]
    public async Task VectorSearchAsync_CanFilterByKind()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertManyAsync(
            Model,
            [
                CreateRecord("entity:User", EmbeddingRecordKinds.Entity, "User", "User", [1, 0]),
                CreateRecord("property:User.UserName", EmbeddingRecordKinds.Property, "User.UserName", "UserName", [1, 0])
            ]);

        var results = await scope.Store.VectorSearchAsync(
            Model,
            [1, 0],
            kind: EmbeddingRecordKinds.Property);

        var result = Assert.Single(results);
        Assert.Equal("property:User.UserName", result.Record.Id);
    }

    [Fact]
    public async Task HybridSearchAsync_CombinesExactAndVectorMatches()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertManyAsync(
            Model,
            [
                CreateRecord(
                    "property:User.UserName",
                    EmbeddingRecordKinds.Property,
                    "User.UserName",
                    "UserName",
                    [0, 1],
                    aliases: ["user name"]),
                CreateRecord(
                    "property:Account.Login",
                    EmbeddingRecordKinds.Property,
                    "Account.Login",
                    "Login",
                    [1, 0])
            ]);

        var results = await scope.Store.HybridSearchAsync(Model, "user name", [1, 0], limit: 2);

        Assert.Equal("property:User.UserName", results[0].Record.Id);
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
    public async Task UpsertAsync_ThrowsWhenRecordModelDoesNotMatchDatabaseModel()
    {
        using var scope = StoreScope.Create();
        var record = CreateRecord(
            "entity:User",
            EmbeddingRecordKinds.Entity,
            "User",
            "User",
            [1, 0],
            model: "other-model");

        var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            scope.Store.UpsertAsync(Model, record));

        Assert.Contains("must match target model", exception.Message);
    }

    [Fact]
    public async Task UpsertAsync_ThrowsWhenEmbeddingDimensionDoesNotMatchDatabase()
    {
        using var scope = StoreScope.Create();

        await scope.Store.UpsertAsync(
            Model,
            CreateRecord("entity:User", EmbeddingRecordKinds.Entity, "User", "User", [1, 0]));

        var exception = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            scope.Store.UpsertAsync(
                Model,
                CreateRecord("entity:Address", EmbeddingRecordKinds.Entity, "Address", "Address", [1, 0, 0])));

        Assert.Contains("Embedding dimension mismatch", exception.Message);
    }

    private static EmbeddingRecord CreateRecord(
        string id,
        string kind,
        string declaration,
        string name,
        float[] embedding,
        IReadOnlyList<string>? aliases = null,
        IReadOnlyList<string>? tags = null,
        string model = Model)
    {
        return new EmbeddingRecord
        {
            Id = id,
            Kind = kind,
            Declaration = declaration,
            Name = name,
            Text = $"Domain {kind}: {name}. Aliases: {string.Join(", ", aliases ?? [])}.",
            EmbeddingModel = model,
            Embedding = embedding,
            Aliases = aliases ?? [],
            Tags = tags ?? [],
            Metadata = new Dictionary<string, string>
            {
                ["declaration"] = declaration
            }
        };
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
}
