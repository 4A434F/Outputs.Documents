namespace Outputs.Documents.Domain.Payments;

[DomainSearch(
    "Bank account",
    "Reusable SEPA bank-account block with bank name, IBAN, and SWIFT/BIC.",
    Aliases = ["conta bancaria", "iban", "swift", "bic", "sepa"],
    Tags = ["common", "banking", "payment"])]
public sealed class BankAccount
{
    [DomainSearch(
        "Bank name",
        "Name of the bank for debit or payment account blocks.",
        Aliases = ["BGOW0044-DEB-NOME-BANCO", "BGOW0044-CNT-NOME-BANCO", "DEB-NOME-BANCO", "CNT-NOME-BANCO"],
        Tags = ["field", "banking", "copybook:BGOW0044"])]
    public string? BankName { get; init; }

    [DomainSearch(
        "IBAN",
        "International bank account number.",
        Aliases = ["BGOW0044-DEB-IBAN", "BGOW0044-CNT-IBAN", "DEB-IBAN", "CNT-IBAN"],
        Tags = ["field", "banking", "copybook:BGOW0044"])]
    public string? Iban { get; init; }

    [DomainSearch(
        "SWIFT",
        "SWIFT or BIC bank identifier.",
        Aliases = ["BGOW0044-DEB-SWIFT", "BGOW0044-CNT-SWIFT", "DEB-SWIFT", "CNT-SWIFT"],
        Tags = ["field", "banking", "copybook:BGOW0044"])]
    public string? Swift { get; init; }
}
