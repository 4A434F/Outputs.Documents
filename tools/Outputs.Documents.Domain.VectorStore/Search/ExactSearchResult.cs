using Outputs.Documents.Domain.VectorStore.Records;

namespace Outputs.Documents.Domain.VectorStore.Search;

public sealed record ExactSearchResult(
    EmbeddingRecord Record,
    string MatchKind,
    double Score);
