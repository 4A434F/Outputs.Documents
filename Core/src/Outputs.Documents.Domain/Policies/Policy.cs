namespace Outputs.Documents.Domain.Policies;

[DomainSearch(
    "Insurance policy",
    "Reusable insurance policy block for policy number, policy transaction, and product information sent by document copybooks.",
    Aliases = ["policy", "apolice", "POLICY-NUMBER", "POLICY-TRANSACTION", "NR-APOLICE"],
    Tags = ["common", "policy", "insurance"])]
public sealed class Policy
{
    [DomainSearch(
        "Policy number",
        "Insurance policy number.",
        Aliases = ["POLICY-NUMBER", "BGOW9068-POLICY-NUMBER", "NR-APOLICE", "BGOW9064-NR-APOLICE"],
        Tags = ["field", "policy"])]
    public string? Number { get; init; }

    [DomainSearch(
        "Policy transaction code",
        "Policy transaction code that identifies the policy operation represented by the document.",
        Aliases = ["POLICY-TRANSACTION", "BGOW9068-POLICY-TRANSACTION"],
        Tags = ["field", "policy", "copybook:BGOW9068"])]
    public string? TransactionCode { get; init; }

    [DomainSearch(
        "Product",
        "Insurance product and branch information associated with the policy.",
        Aliases = ["PRODUTO", "BGOW9068-PRODUTO", "PRODUCT", "BGOW9068-PRODUCT", "COD-PRODUTO", "BGOW0044-COD-PRODUTO"],
        Tags = ["field", "policy", "product"])]
    public ProductReference Product { get; init; } = new();
}
