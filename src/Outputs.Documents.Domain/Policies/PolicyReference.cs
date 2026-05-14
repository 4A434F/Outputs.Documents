namespace Outputs.Documents.Domain.Policies;

[DomainSearch(
    "Policy reference",
    "Reusable insurance policy reference block with client, policy, company, brand, origin system, and agent identifiers.",
    Aliases = ["apolice", "policy", "numero apolice", "cliente", "mediador"],
    Tags = ["common", "policy", "reference"])]
public sealed class PolicyReference
{
    [DomainSearch("Company code", "Company identifier.", Aliases = ["BGOW0044-COD-COMPANHIA", "COD-COMPANHIA"], Tags = ["field", "policy", "copybook:BGOW0044"])]
    public string? CompanyCode { get; init; }

    [DomainSearch("Brand code", "Brand identifier.", Aliases = ["BGOW0044-COD-MARCA", "COD-MARCA"], Tags = ["field", "policy", "copybook:BGOW0044"])]
    public string? BrandCode { get; init; }

    [DomainSearch("Brand auxiliary code", "Auxiliary brand indicator.", Aliases = ["BGOW0044-AUX-MARCA", "AUX-MARCA"], Tags = ["field", "policy", "copybook:BGOW0044"])]
    public string? BrandAuxiliaryCode { get; init; }

    [DomainSearch("Agent number", "Agent or mediator number.", Aliases = ["BGOW0044-NR-AGENTE", "NR-AGENTE"], Tags = ["field", "policy", "copybook:BGOW0044"])]
    public string? AgentNumber { get; init; }

    [DomainSearch("Client number", "Client number.", Aliases = ["BGOW0044-NR-CLIENTE", "NR-CLIENTE"], Tags = ["field", "policy", "copybook:BGOW0044"])]
    public string? ClientNumber { get; init; }

    [DomainSearch("Policy number", "Policy number.", Aliases = ["BGOW0044-NR-APOLICE", "NR-APOLICE"], Tags = ["field", "policy", "copybook:BGOW0044"])]
    public string? PolicyNumber { get; init; }

    [DomainSearch("Origin system code", "Origin system identifier.", Aliases = ["BGOW0044-COD-ORIGEM", "COD-ORIGEM"], Tags = ["field", "policy", "copybook:BGOW0044"])]
    public string? OriginSystemCode { get; init; }

    [DomainSearch("Flyer indicator", "Flyer inclusion indicator.", Aliases = ["BGOW0044-IND-FLYER", "IND-FLYER"], Tags = ["field", "policy", "copybook:BGOW0044"])]
    public string? FlyerIndicator { get; init; }
}
