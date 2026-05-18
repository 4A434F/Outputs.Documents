using System.ComponentModel;
using ModelContextProtocol.Server;
using Outputs.Documents.Domain.VectorStore.Alignment;
using Outputs.Documents.Domain.VectorStore.Descriptors;
using Outputs.Documents.Domain.VectorStore.Records;

namespace Outputs.Documents.Domain.VectorStore.McpServer.Tools;

[McpServerToolType]
public static class VectorStoreMcpTools
{
    [McpServerTool]
    [Description("Returns the fixed alignment prompts that callers must embed before saving or checking alignment.")]
    public static IReadOnlyList<AlignmentPrompt> ListAlignmentPrompts()
    {
        return DomainVectorStoreAlignmentPrompts.All;
    }

    [McpServerTool]
    [Description("Lists embedding model names that already have a vector-store database.")]
    public static Task<IReadOnlyList<string>> ListModelsAsync(
        IDomainVectorStore store,
        CancellationToken cancellationToken = default)
    {
        return store.ListModelsAsync(cancellationToken);
    }

    [McpServerTool]
    [Description("Describes the embedding inputs for a loaded C# domain type. Encode each descriptor text outside this server, then call UpsertDomainTypeAsync.")]
    public static IReadOnlyList<DomainEmbeddingDescriptor> DescribeDomainType(
        IDomainVectorStore store,
        [Description("Full type name or assembly-qualified name, for example 'Outputs.Documents.FSCD.Contracts.FS000CancelationLetter'.")]
        string domainTypeName)
    {
        return store.Describe(ResolveDomainType(domainTypeName));
    }

    [McpServerTool]
    [Description("Creates or updates all embedding records for a loaded C# domain type. Record metadata is read from DomainSearchAttribute; callers only supply descriptor ids and vectors.")]
    public static async Task<IReadOnlyList<DomainEmbeddingDescriptor>> UpsertDomainTypeAsync(
        IDomainVectorStore store,
        [Description("Embedding model name. This routes to the model-specific SQLite database.")]
        string modelName,
        [Description("Full type name or assembly-qualified name.")]
        string domainTypeName,
        [Description("Embedding vectors keyed by descriptor id. Use DescribeDomainType first.")]
        DomainEmbeddingValue[] embeddings,
        CancellationToken cancellationToken = default)
    {
        var domainType = ResolveDomainType(domainTypeName);

        await store.UpsertAsync(modelName, domainType, embeddings, cancellationToken);
        return store.Describe(domainType);
    }

    [McpServerTool]
    [Description("Gets one embedding record by exact id. This does not perform close-match search.")]
    public static Task<EmbeddingRecord?> GetRecordAsync(
        IDomainVectorStore store,
        string modelName,
        string id,
        CancellationToken cancellationToken = default)
    {
        return store.GetAsync(modelName, id, cancellationToken);
    }

    [McpServerTool]
    [Description("Lists embedding records for a model, optionally filtered by kind.")]
    public static Task<IReadOnlyList<EmbeddingRecord>> ListRecordsAsync(
        IDomainVectorStore store,
        string modelName,
        string? kind = null,
        CancellationToken cancellationToken = default)
    {
        return store.ListAsync(modelName, kind, cancellationToken);
    }

    [McpServerTool]
    [Description("Deletes one embedding record by exact id.")]
    public static async Task<MutationResult> DeleteRecordAsync(
        IDomainVectorStore store,
        string modelName,
        string id,
        CancellationToken cancellationToken = default)
    {
        await store.DeleteAsync(modelName, id, cancellationToken);
        return new MutationResult(true);
    }

    [McpServerTool]
    [Description("Deletes embedding records by kind and declaration.")]
    public static async Task<MutationResult> DeleteByDeclarationAsync(
        IDomainVectorStore store,
        string modelName,
        string kind,
        string declaration,
        CancellationToken cancellationToken = default)
    {
        await store.DeleteByDeclarationAsync(modelName, kind, declaration, cancellationToken);
        return new MutationResult(true);
    }

    [McpServerTool]
    [Description("Runs exact search over ids, declarations, names, aliases, tags, metadata, and embedded text.")]
    public static async Task<IReadOnlyList<ExactSearchResultDto>> ExactSearchAsync(
        IDomainVectorStore store,
        string modelName,
        string query,
        int limit = 10,
        string? kind = null,
        CancellationToken cancellationToken = default)
    {
        var results = await store.ExactSearchAsync(modelName, query, limit, kind, cancellationToken);
        return results.Select(ExactSearchResultDto.From).ToList();
    }

    [McpServerTool]
    [Description("Runs vector similarity search using a query embedding that was encoded outside this MCP server.")]
    public static async Task<IReadOnlyList<VectorSearchResultDto>> VectorSearchAsync(
        IDomainVectorStore store,
        string modelName,
        float[] queryEmbedding,
        int limit = 10,
        double? minScore = null,
        string? kind = null,
        CancellationToken cancellationToken = default)
    {
        var results = await store.VectorSearchAsync(modelName, queryEmbedding, limit, minScore, kind, cancellationToken);
        return results.Select(VectorSearchResultDto.From).ToList();
    }

    [McpServerTool]
    [Description("Runs hybrid search by combining exact query matching with vector similarity.")]
    public static async Task<IReadOnlyList<HybridSearchResultDto>> HybridSearchAsync(
        IDomainVectorStore store,
        string modelName,
        string query,
        float[] queryEmbedding,
        int limit = 10,
        double? minScore = null,
        string? kind = null,
        CancellationToken cancellationToken = default)
    {
        var results = await store.HybridSearchAsync(modelName, query, queryEmbedding, limit, minScore, kind, cancellationToken);
        return results.Select(HybridSearchResultDto.From).ToList();
    }

    [McpServerTool]
    [Description("Saves the five fixed alignment embeddings for a model. Use ListAlignmentPrompts first and embed exactly those prompt texts outside this server.")]
    public static async Task<MutationResult> SaveAlignmentSetAsync(
        IDomainVectorStore store,
        string modelName,
        AlignmentEmbedding[] embeddings,
        CancellationToken cancellationToken = default)
    {
        await store.SaveAlignmentSetAsync(modelName, embeddings, cancellationToken);
        return new MutationResult(true);
    }

    [McpServerTool]
    [Description("Checks current alignment embeddings against the saved baseline for the same fixed alignment prompts.")]
    public static Task<IReadOnlyList<AlignmentCheckResult>> CheckAlignmentAsync(
        IDomainVectorStore store,
        string modelName,
        AlignmentEmbedding[] embeddings,
        double minimumSimilarity = 0.98,
        CancellationToken cancellationToken = default)
    {
        return store.CheckAlignmentAsync(modelName, embeddings, minimumSimilarity, cancellationToken);
    }

    private static Type ResolveDomainType(string domainTypeName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(domainTypeName);

        var type = Type.GetType(domainTypeName, throwOnError: false)
            ?? AppDomain.CurrentDomain
                .GetAssemblies()
                .Select(assembly => assembly.GetType(domainTypeName, throwOnError: false))
                .FirstOrDefault(candidate => candidate is not null);

        return type ?? throw new InvalidOperationException(
            $"Could not find loaded domain type '{domainTypeName}'. Use an assembly-qualified name or a type from an assembly referenced by the MCP server.");
    }
}
