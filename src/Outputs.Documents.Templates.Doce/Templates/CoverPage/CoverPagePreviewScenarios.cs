using Outputs.Documents.Domain.Doce;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Templates.Doce;

public sealed class CoverPagePreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new("cover-short", "Cover page with destination", typeof(CoverPage), CoverPageShort());
        yield return new("cover-full", "Cover page summary only", typeof(CoverPage), CoverPageFull());
    }

    private static CoverPage CoverPageFull()
    {
        return new CoverPage(
            PostalObjectType: "Manual",
            SegmentNumber: "S001",
            Title: "Title Title Title Title",
            Description: "Description Description Description",
            ProviderCode: "CTT",
            Department: null,
            Addr1: null,
            Addr2: null,
            Addr3: null,
            Addr4: null,
            PaperType: "A4",
            TotalSheets: 300,
            TotalPrintedPages: 75,
            TotalPostalObjects: 100,
            DividerCount: null,
            TotalAdicional1: null,
            TotalAdicional2: null,
            TotalAdicional3: null,
            TotalAdicional4: null,
            TotalAdicional5: null,
            DocumentDate: new DateTime(2025, 7, 9, 14, 35, 50));
    }

    private static CoverPage CoverPageShort()
    {
        return new CoverPage(
            PostalObjectType: "DL",
            SegmentNumber: "S001",
            Title: "Title Title Title Title",
            Description: "Description Description Description",
            ProviderCode: "CTT",
            Department: "Department",
            Addr1: "Addr1Addr1Addr1Addr1Addr1Addr1Addr1",
            Addr2: "Addr2Addr2Addr2Addr2Addr2Addr2Addr2",
            Addr3: "Addr3Addr3Addr3Addr3Addr3Addr3Addr3",
            Addr4: "Addr4Addr4Addr4Addr4Addr4Addr4Addr4",
            PaperType: "A4",
            TotalSheets: 300,
            TotalPrintedPages: 75,
            TotalPostalObjects: 100,
            DividerCount: 6,
            TotalAdicional1: 12,
            TotalAdicional2: 1,
            TotalAdicional3: 1,
            TotalAdicional4: 13,
            TotalAdicional5: 14,
            DocumentDate: new DateTime(2025, 7, 9, 14, 35, 50));
    }
}
