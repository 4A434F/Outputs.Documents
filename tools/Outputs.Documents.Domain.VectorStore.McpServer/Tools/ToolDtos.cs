using Outputs.Documents.Domain.VectorStore.Records;
using Outputs.Documents.Domain.VectorStore.Search;

namespace Outputs.Documents.Domain.VectorStore.McpServer.Tools;

public sealed record MutationResult(bool Success);

public sealed record ExactSearchResultDto(
    EmbeddingRecord Record,
    string MatchKind,
    double Score)
{
    public static ExactSearchResultDto From(ExactSearchResult result)
    {
        return new ExactSearchResultDto(
            result.Record,
            result.MatchKind,
            result.Score);
    }
}

public sealed record VectorSearchResultDto(
    EmbeddingRecord Record,
    double Similarity,
    double Distance)
{
    public static VectorSearchResultDto From(VectorSearchResult result)
    {
        return new VectorSearchResultDto(
            result.Record,
            result.Similarity,
            result.Distance);
    }
}

public sealed record HybridSearchResultDto(
    EmbeddingRecord Record,
    double Score,
    double? VectorSimilarity,
    IReadOnlyList<string> MatchKinds)
{
    public static HybridSearchResultDto From(HybridSearchResult result)
    {
        return new HybridSearchResultDto(
            result.Record,
            result.Score,
            result.VectorSimilarity,
            result.MatchKinds);
    }
}
