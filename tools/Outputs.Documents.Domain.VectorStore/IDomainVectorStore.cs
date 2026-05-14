using Outputs.Documents.Domain.VectorStore.Alignment;
using Outputs.Documents.Domain.VectorStore.Descriptors;
using Outputs.Documents.Domain.VectorStore.Records;
using Outputs.Documents.Domain.VectorStore.Search;

namespace Outputs.Documents.Domain.VectorStore;

public interface IDomainVectorStore
{
    IReadOnlyList<DomainEmbeddingDescriptor> Describe(Type domainType);

    Task UpsertAsync(
        string modelName,
        Type domainType,
        IEnumerable<DomainEmbeddingValue> embeddings,
        CancellationToken cancellationToken = default);

    Task UpsertManyAsync(
        string modelName,
        IEnumerable<DomainEmbeddingRegistration> registrations,
        CancellationToken cancellationToken = default);

    Task<EmbeddingRecord?> GetAsync(
        string modelName,
        string id,
        CancellationToken cancellationToken = default);

    Task<IReadOnlyList<EmbeddingRecord>> ListAsync(
        string modelName,
        string? kind = null,
        CancellationToken cancellationToken = default);

    Task DeleteAsync(
        string modelName,
        string id,
        CancellationToken cancellationToken = default);

    Task DeleteByDeclarationAsync(
        string modelName,
        string kind,
        string declaration,
        CancellationToken cancellationToken = default);

    Task<IReadOnlyList<string>> ListModelsAsync(
        CancellationToken cancellationToken = default);

    Task<IReadOnlyList<ExactSearchResult>> ExactSearchAsync(
        string modelName,
        string query,
        int limit = 10,
        string? kind = null,
        CancellationToken cancellationToken = default);

    Task<IReadOnlyList<VectorSearchResult>> VectorSearchAsync(
        string modelName,
        float[] queryEmbedding,
        int limit = 10,
        double? minScore = null,
        string? kind = null,
        CancellationToken cancellationToken = default);

    Task<IReadOnlyList<HybridSearchResult>> HybridSearchAsync(
        string modelName,
        string query,
        float[] queryEmbedding,
        int limit = 10,
        double? minScore = null,
        string? kind = null,
        CancellationToken cancellationToken = default);

    Task SaveAlignmentSetAsync(
        string modelName,
        IEnumerable<AlignmentEmbedding> embeddings,
        CancellationToken cancellationToken = default);

    Task<IReadOnlyList<AlignmentCheckResult>> CheckAlignmentAsync(
        string modelName,
        IEnumerable<AlignmentEmbedding> embeddings,
        double minimumSimilarity = 0.98,
        CancellationToken cancellationToken = default);
}
