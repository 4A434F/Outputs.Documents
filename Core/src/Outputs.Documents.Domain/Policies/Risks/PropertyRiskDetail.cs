using Outputs.Documents.Domain.Locations;

namespace Outputs.Documents.Domain.Policies.Risks;

[DomainSearch(
    "Property risk detail",
    "Multi-risk property detail with object code and risk location address.",
    Aliases = ["multirisco", "imovel", "morada risco"],
    Tags = ["common", "risk", "property", "address"])]
public sealed class PropertyRiskDetail
{
    public string? ObjectCode { get; init; }

    public PostalAddress? Address { get; init; }
}
