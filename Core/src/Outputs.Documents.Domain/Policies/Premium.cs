namespace Outputs.Documents.Domain.Policies;

[DomainSearch(
    "Premium",
    "Reusable premium and charge breakdown with commercial premium, fees, totals, additional values, first fraction, and following fractions.",
    Aliases = ["premium", "premio", "DADOS-VALOR", "DV-PREMIO-COM", "DV-PREMIO-TOT"],
    Tags = ["common", "premium", "amount"])]
public sealed class Premium
{
    [DomainSearch(
        "Commercial premium",
        "Commercial premium amount.",
        Aliases = ["DV-PREMIO-COM", "BGOW9064-DV-PREMIO-COM"],
        Tags = ["field", "premium", "amount"])]
    public string? Commercial { get; init; }

    [DomainSearch(
        "Charges",
        "Fiscal and parafiscal charges.",
        Aliases = ["DV-ENCARGOS", "BGOW9064-DV-ENCARGOS"],
        Tags = ["field", "premium", "amount"])]
    public string? Charges { get; init; }

    [DomainSearch(
        "Total premium",
        "Total premium amount.",
        Aliases = ["DV-PREMIO-TOT", "BGOW9064-DV-PREMIO-TOT"],
        Tags = ["field", "premium", "amount"])]
    public string? Total { get; init; }

    [DomainSearch(
        "Additional commercial premium",
        "Additional commercial premium amount.",
        Aliases = ["DV-PREMIO-COM-AD", "BGOW9064-DV-PREMIO-COM-AD"],
        Tags = ["field", "premium", "amount"])]
    public string? AdditionalCommercial { get; init; }

    [DomainSearch(
        "Additional charges",
        "Additional fiscal and parafiscal charges.",
        Aliases = ["DV-ENCARGOS-AD", "BGOW9064-DV-ENCARGOS-AD"],
        Tags = ["field", "premium", "amount"])]
    public string? AdditionalCharges { get; init; }

    [DomainSearch(
        "Additional total premium",
        "Additional total premium amount.",
        Aliases = ["DV-PREMIO-TOT-AD", "BGOW9064-DV-PREMIO-TOT-AD"],
        Tags = ["field", "premium", "amount"])]
    public string? AdditionalTotal { get; init; }

    [DomainSearch(
        "First fraction commercial premium",
        "Commercial premium amount for the first fraction.",
        Aliases = ["DV-PREMIO-COM-1F", "BGOW9064-DV-PREMIO-COM-1F"],
        Tags = ["field", "premium", "amount"])]
    public string? FirstFractionCommercial { get; init; }

    [DomainSearch(
        "First fraction charges",
        "Charges amount for the first fraction.",
        Aliases = ["DV-ENCARGOS-1F", "BGOW9064-DV-ENCARGOS-1F"],
        Tags = ["field", "premium", "amount"])]
    public string? FirstFractionCharges { get; init; }

    [DomainSearch(
        "First fraction total premium",
        "Total premium amount for the first fraction.",
        Aliases = ["DV-PREMIO-TOT-1F", "BGOW9064-DV-PREMIO-TOT-1F"],
        Tags = ["field", "premium", "amount"])]
    public string? FirstFractionTotal { get; init; }

    [DomainSearch(
        "Following fractions commercial premium",
        "Commercial premium amount for following fractions.",
        Aliases = ["DV-PREMIO-COM-FS", "BGOW9064-DV-PREMIO-COM-FS"],
        Tags = ["field", "premium", "amount"])]
    public string? FollowingFractionsCommercial { get; init; }

    [DomainSearch(
        "Following fractions charges",
        "Charges amount for following fractions.",
        Aliases = ["DV-ENCARGOS-FS", "BGOW9064-DV-ENCARGOS-FS"],
        Tags = ["field", "premium", "amount"])]
    public string? FollowingFractionsCharges { get; init; }

    [DomainSearch(
        "Following fractions total premium",
        "Total premium amount for following fractions.",
        Aliases = ["DV-PREMIO-TOT-FS", "BGOW9064-DV-PREMIO-TOT-FS"],
        Tags = ["field", "premium", "amount"])]
    public string? FollowingFractionsTotal { get; init; }
}
