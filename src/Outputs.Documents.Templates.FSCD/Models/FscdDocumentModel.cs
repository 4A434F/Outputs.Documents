using Outputs.Documents.Domain;

namespace Outputs.Documents.Templates.FSCD;

public sealed class FscdDocumentModel : IDocumentModel
{
    public string Title { get; init; } = string.Empty;
}
