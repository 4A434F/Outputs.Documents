using Outputs.Documents.Domain;

namespace Outputs.Documents.Templates.FSCD;

public sealed class CourtesyLetter : IDocumentModel
{
    public string Title { get; init; } = string.Empty;

    public string Body { get; init; } = string.Empty;

    public CourtesyLetterHeader? Header { get; init; }

    public CourtesyLetterFooter? Footer { get; init; }
}

public sealed class CourtesyLetterHeader
{
    public string RecipientName { get; init; } = string.Empty;
}

public sealed class CourtesyLetterFooter
{
    public string ReferenceNumber { get; init; } = string.Empty;
}
