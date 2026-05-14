namespace Outputs.Documents.Tools.Dashboard.Services;

public sealed record VectorStoreSearchRequest(
    string ModelName,
    string Query,
    string? Kind,
    int Limit);
