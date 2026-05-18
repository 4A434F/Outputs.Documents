namespace Outputs.Documents.Domain.Policies;

[DomainSearch(
    "Product reference",
    "Reusable insurance product and branch reference block.",
    Aliases = ["produto", "ramo", "ramo produto", "moeda", "PRODUTO", "PRODUCT"],
    Tags = ["common", "policy", "product"])]
public sealed class ProductReference
{
    [DomainSearch("Currency code", "Currency code.", Aliases = ["BGOW0044-COD-MOEDA", "COD-MOEDA"], Tags = ["field", "product", "copybook:BGOW0044"])]
    public string? CurrencyCode { get; init; }

    [DomainSearch("Product code", "Insurance product code.", Aliases = ["BGOW0044-COD-PRODUTO", "COD-PRODUTO", "BGOW9068-PRODUTO", "PRODUTO"], Tags = ["field", "product", "copybook:BGOW0044", "copybook:BGOW9068"])]
    public string? ProductCode { get; init; }

    [DomainSearch("Branch code", "Insurance branch code.", Aliases = ["BGOW0044-COD-RAMO", "COD-RAMO"], Tags = ["field", "product", "copybook:BGOW0044"])]
    public string? BranchCode { get; init; }

    [DomainSearch("Branch product description", "Branch and product description.", Aliases = ["BGOW0044-DESCR-RAMO-PROD", "DESCR-RAMO-PROD", "BGOW9068-PRODUCT", "PRODUCT"], Tags = ["field", "product", "copybook:BGOW0044", "copybook:BGOW9068"])]
    public string? BranchProductDescription { get; init; }
}
