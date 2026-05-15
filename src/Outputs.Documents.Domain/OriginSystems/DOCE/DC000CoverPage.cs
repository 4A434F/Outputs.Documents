
namespace Outputs.Documents.Domain.Contracts.DOCE;

[DomainSearch(
    "DC000 Cover Page",
    "DOCE cover page contract with postal object totals, provider information, segment data, and document date.",
    Aliases = ["cover page", "capa", "folha rosto", "postal object summary"],
    Tags = ["contract", "doce", "DC000", "cover-page"])]
public record DC000CoverPage(
    string PostalObjectType,
    string Title,
    string SegmentNumber,
    string Description,
    string ProviderCode,
    string? Department,
    string? Addr1,
    string? Addr2,
    string? Addr3,
    string? Addr4,
    string PaperType,
    int TotalSheets,
    int TotalPrintedPages,
    int TotalPostalObjects,
    int? DividerCount,
    int? TotalAdicional1,
    int? TotalAdicional2,
    int? TotalAdicional3,
    int? TotalAdicional4,
    int? TotalAdicional5,
    DateTime DocumentDate) : IDocumentModel;
