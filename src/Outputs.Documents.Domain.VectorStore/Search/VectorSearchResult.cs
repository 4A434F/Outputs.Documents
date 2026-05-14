using Outputs.Documents.Domain.VectorStore.Records;

namespace Outputs.Documents.Domain.VectorStore.Search;

public sealed record VectorSearchResult(
    EmbeddingRecord Record,
    double Similarity,
    double Distance);
