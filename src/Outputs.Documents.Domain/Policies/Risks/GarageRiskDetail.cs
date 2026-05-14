namespace Outputs.Documents.Domain.Policies.Risks;

[DomainSearch(
    "Garage risk detail",
    "Garage automobile risk detail with driving license and category description.",
    Aliases = ["garagista", "carta conducao", "categoria"],
    Tags = ["common", "risk", "vehicle"])]
public sealed class GarageRiskDetail
{
    public string? DrivingLicense { get; init; }

    public string? Category { get; init; }
}
