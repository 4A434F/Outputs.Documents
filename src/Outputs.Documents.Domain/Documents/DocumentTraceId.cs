namespace Outputs.Documents.Domain.Documents;

[DomainSearch(
    "Document trace identifier",
    "Reusable document trace text printed on DOCE documents for operational identification.",
    Aliases = ["trace id", "trace text", "document trace"],
    Tags = ["common", "doce", "trace", "identifier"])]
public class DocumentTraceId
{
    public string? Line1 { get; set; }

    public string? Line2 { get; set; }
}
