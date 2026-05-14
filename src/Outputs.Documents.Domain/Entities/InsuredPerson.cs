namespace Outputs.Documents.Domain.Entities;

[DomainSearch(
    "Insured person",
    "Reusable insured person block used in life, health, and risk-unit details.",
    Aliases = ["pessoa segura", "insured person"],
    Tags = ["common", "entity", "insured"])]
public sealed class InsuredPerson
{
    public string? Name { get; init; }

    public string? TaxIdentificationNumber { get; init; }

    public DateOnly? BirthDate { get; init; }
}
