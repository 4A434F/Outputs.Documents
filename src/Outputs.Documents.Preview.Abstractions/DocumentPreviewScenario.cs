namespace Outputs.Documents.Preview.Abstractions;

public sealed record DocumentPreviewScenario(
    string Key,
    string Name,
    Type ModelType,
    object Model);
