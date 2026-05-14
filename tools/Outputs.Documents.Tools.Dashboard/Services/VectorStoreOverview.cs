namespace Outputs.Documents.Tools.Dashboard.Services;

public sealed record VectorStoreOverview(
    IReadOnlyList<string> Models,
    string? SelectedModel,
    IReadOnlyList<string> Kinds,
    int RecordCount);
