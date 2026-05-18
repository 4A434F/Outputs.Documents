using Outputs.Documents.Domain.Entities;

namespace Outputs.Documents.Domain.Policies.Risks;

[DomainSearch(
    "Life risk detail",
    "Risk detail with up to two insured people for life-risk products.",
    Aliases = ["vida risco", "pessoa segura"],
    Tags = ["common", "risk", "life"])]
public sealed class LifeRiskDetail
{
    public InsuredPerson? FirstInsuredPerson { get; init; }

    public InsuredPerson? SecondInsuredPerson { get; init; }
}
