using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Templates.FSCD;

public sealed class FscdPreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new DocumentPreviewScenario(
            "default",
            "Default",
            typeof(FscdDocumentModel),
            new FscdDocumentModel { Title = "FSCD document preview" });

        yield return new DocumentPreviewScenario(
            "standard-letter",
            "Standard letter",
            typeof(CourtesyLetter),
            new CourtesyLetter
            {
                Title = "Courtesy letter",
                Body = "This sample exists to preview the default courtesy letter template.",
                Header = new CourtesyLetterHeader { RecipientName = "Jane Sample" },
                Footer = new CourtesyLetterFooter { ReferenceNumber = "FSCD-2026-001" }
            });

        yield return new DocumentPreviewScenario(
            "long-body",
            "Long body",
            typeof(CourtesyLetter),
            new CourtesyLetter
            {
                Title = "Courtesy letter with long content",
                Body = string.Join(" ", Enumerable.Repeat("This paragraph checks wrapping and spacing in preview mode.", 8)),
                Header = new CourtesyLetterHeader { RecipientName = "Very Long Recipient Name Incorporated" },
                Footer = new CourtesyLetterFooter { ReferenceNumber = "FSCD-2026-LONG" }
            });
    }
}
