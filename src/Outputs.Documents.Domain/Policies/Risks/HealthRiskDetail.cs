using Outputs.Documents.Domain.Entities;

namespace Outputs.Documents.Domain.Policies.Risks;

[DomainSearch(
    "Health risk detail",
    "Health risk detail with insured person and intervention capital.",
    Aliases = ["saude", "capital inter", "pessoa segura"],
    Tags = ["common", "risk", "health"])]
public sealed class HealthRiskDetail
{
    public decimal? InterventionCapital { get; init; }

    public InsuredPerson? InsuredPerson { get; init; }
}
