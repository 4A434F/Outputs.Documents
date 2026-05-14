namespace Outputs.Documents.Domain.Payments;

[DomainSearch(
    "ATM payment reference",
    "Reusable Portuguese ATM payment entity and reference block.",
    Aliases = ["pagamento atm", "entidade referencia"],
    Tags = ["common", "payment", "atm"])]
public sealed class AtmPaymentReference
{
    [DomainSearch(
        "ATM entity",
        "Portuguese ATM payment entity.",
        Aliases = ["BGOW0044-ATM-ENTIDADE", "ATM-ENTIDADE"],
        Tags = ["field", "payment", "copybook:BGOW0044"])]
    public string? Entity { get; init; }

    [DomainSearch(
        "ATM reference",
        "Portuguese ATM payment reference.",
        Aliases = ["BGOW0044-ATM-REF", "ATM-REF"],
        Tags = ["field", "payment", "copybook:BGOW0044"])]
    public string? Reference { get; init; }
}
