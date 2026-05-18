using Outputs.Documents.Domain.VectorStore.Records;

namespace Outputs.Documents.Domain.VectorStore.Search;

public sealed record HybridSearchResult(
    EmbeddingRecord Record,
    double Score,
    double? VectorSimilarity,
    IReadOnlyList<string> MatchKinds);
