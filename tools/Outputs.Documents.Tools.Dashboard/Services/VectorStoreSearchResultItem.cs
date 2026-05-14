namespace Outputs.Documents.Tools.Dashboard.Services;

public sealed record VectorStoreSearchResultItem(
    string Id,
    string Kind,
    string Declaration,
    string Name,
    string Text,
    string MatchKind,
    double Score,
    int EmbeddingDimensions,
    IReadOnlyList<string> Aliases,
    IReadOnlyList<string> Tags,
    IReadOnlyDictionary<string, string> Metadata);
