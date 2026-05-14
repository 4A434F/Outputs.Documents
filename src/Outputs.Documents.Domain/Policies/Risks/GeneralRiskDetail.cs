namespace Outputs.Documents.Domain.Policies.Risks;

[DomainSearch(
    "General risk detail",
    "Generic insured object or risk-unit description for risks without a specialized shape.",
    Aliases = ["detalhe geral", "objeto seguro"],
    Tags = ["common", "risk"])]
public sealed class GeneralRiskDetail
{
    public string? Description { get; init; }
}
