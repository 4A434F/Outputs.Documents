using Outputs.Documents.Domain;

namespace Outputs.Documents.Domain.Doce;

public record CoverPage(
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
