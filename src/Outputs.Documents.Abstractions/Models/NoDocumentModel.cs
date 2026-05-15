namespace Outputs.Documents.Abstractions;

public sealed class NoDocumentModel : IDocumentModel
{
    public static NoDocumentModel Instance { get; } = new();
}
