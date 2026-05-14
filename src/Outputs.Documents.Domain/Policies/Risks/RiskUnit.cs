namespace Outputs.Documents.Domain.Policies.Risks;

[DomainSearch(
    "Risk unit",
    "Reusable insured object or risk-unit block. The detail shape depends on risk unit type.",
    Aliases = ["unidade em risco", "objeto seguro", "risk unit"],
    Tags = ["common", "risk", "insured-object"])]
public sealed class RiskUnit
{
    public int? Count { get; init; }

    public RiskUnitType Type { get; init; }

    [DomainSearch(
        "Risk description",
        "Insured object or risk-unit description.",
        Aliases = ["OS-OBJECTO-SEG", "DO-OBJETO-SEG", "BGOW9064-OS-OBJECTO-SEG", "BGOW9064-DO-OBJETO-SEG"],
        Tags = ["field", "risk"])]
    public string? Description { get; init; }

    [DomainSearch(
        "Risk location line 1",
        "First risk location line.",
        Aliases = ["OS-LOCAL-RISC1", "BGOW9064-OS-LOCAL-RISC1"],
        Tags = ["field", "risk", "address"])]
    public string? RiskLocationLine1 { get; init; }

    [DomainSearch(
        "Risk location line 2",
        "Second risk location line.",
        Aliases = ["OS-LOCAL-RISC2", "BGOW9064-OS-LOCAL-RISC2"],
        Tags = ["field", "risk", "address"])]
    public string? RiskLocationLine2 { get; init; }

    [DomainSearch(
        "Risk location description",
        "Detailed risk location description.",
        Aliases = ["DO-LOCAL-RISC", "BGOW9064-DO-LOCAL-RISC"],
        Tags = ["field", "risk", "address"])]
    public string? RiskLocationDescription { get; init; }

    [DomainSearch(
        "Insured capital",
        "Risk or insured-object capital amount.",
        Aliases = ["OS-CAPITAL-SEG", "BGOW9064-OS-CAPITAL-SEG"],
        Tags = ["field", "risk", "amount"])]
    public string? InsuredCapital { get; init; }

    [DomainSearch(
        "Product description",
        "Product description related to the risk unit.",
        Aliases = ["DO-PRODUTO", "BGOW9064-DO-PRODUTO"],
        Tags = ["field", "risk", "product"])]
    public string? ProductDescription { get; init; }

    [DomainSearch(
        "Policy number",
        "Policy number related to the risk unit.",
        Aliases = ["DO-APOLICE", "BGOW9064-DO-APOLICE"],
        Tags = ["field", "risk", "policy"])]
    public string? PolicyNumber { get; init; }

    [DomainSearch(
        "Activity description",
        "Activity description related to the risk unit.",
        Aliases = ["DO-ACTIVIDADE", "BGOW9064-DO-ACTIVIDADE"],
        Tags = ["field", "risk"])]
    public string? ActivityDescription { get; init; }

    [DomainSearch(
        "Modality description",
        "Modality description related to the risk unit.",
        Aliases = ["DO-MODALIDADE", "BGOW9064-DO-MODALIDADE"],
        Tags = ["field", "risk"])]
    public string? ModalityDescription { get; init; }

    [DomainSearch(
        "Coverage scope description",
        "Coverage scope description related to the risk unit.",
        Aliases = ["DO-AMBITO-COB", "BGOW9064-DO-AMBITO-COB"],
        Tags = ["field", "risk", "coverage"])]
    public string? CoverageScopeDescription { get; init; }

    [DomainSearch(
        "Worker count",
        "Number of workers related to the risk unit.",
        Aliases = ["DO-NR-TRABALH", "BGOW9064-DO-NR-TRABALH"],
        Tags = ["field", "risk"])]
    public string? WorkerCount { get; init; }

    public GeneralRiskDetail? General { get; init; }

    public LifeRiskDetail? LifeRisk { get; init; }

    public HealthRiskDetail? Health { get; init; }

    public VehicleRiskDetail? Vehicle { get; init; }

    public GarageRiskDetail? Garage { get; init; }

    public GeneralRiskDetail? OtherVehicle { get; init; }

    public PropertyRiskDetail? MultiRisk { get; init; }

    public GeneralRiskDetail? WorkAccident { get; init; }
}
