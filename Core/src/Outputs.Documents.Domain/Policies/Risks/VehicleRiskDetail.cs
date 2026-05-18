namespace Outputs.Documents.Domain.Policies.Risks;

[DomainSearch(
    "Vehicle risk detail",
    "Automobile vehicle detail with brand, model, version, and registration number.",
    Aliases = ["automovel", "veiculo", "marca", "modelo", "matricula"],
    Tags = ["common", "risk", "vehicle"])]
public sealed class VehicleRiskDetail
{
    public string? Brand { get; init; }

    public string? Model { get; init; }

    public string? Version { get; init; }

    public string? RegistrationNumber { get; init; }
}
