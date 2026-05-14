namespace Outputs.Documents.Domain.Policies.Coverages;

[DomainSearch(
    "Coverage",
    "Reusable insurance coverage block with coverage type, code, description, table type, deductible, indemnity limit, literal text, and capital.",
    Aliases = ["coverage", "cobertura", "COBERTURAS", "CB-TIPO-COBERTURA", "CB-DESC-COB"],
    Tags = ["common", "coverage"])]
public sealed class Coverage
{
    [DomainSearch(
        "Coverage type",
        "Coverage type or level.",
        Aliases = ["CB-TIPO-COBERTURA", "BGOW9064-CB-TIPO-COBERTURA"],
        Tags = ["field", "coverage"])]
    public string? TypeCode { get; init; }

    [DomainSearch(
        "Coverage code",
        "Coverage code.",
        Aliases = ["CB-COD-COB", "BGOW9064-CB-COD-COB"],
        Tags = ["field", "coverage"])]
    public string? Code { get; init; }

    [DomainSearch(
        "Coverage description",
        "Coverage description.",
        Aliases = ["CB-DESC-COB", "BGOW9064-CB-DESC-COB"],
        Tags = ["field", "coverage"])]
    public string? Description { get; init; }

    [DomainSearch(
        "Coverage table type",
        "Identifier for the table layout used to list the coverage.",
        Aliases = ["CB-TIPO-TABELA", "BGOW9064-CB-TIPO-TABELA"],
        Tags = ["field", "coverage"])]
    public string? TableType { get; init; }

    [DomainSearch(
        "Deductible",
        "Deductible detail for the coverage.",
        Aliases = ["CB-FRANQUIA", "BGOW9064-CB-FRANQUIA"],
        Tags = ["field", "coverage", "deductible"])]
    public CoverageDeductible? Deductible { get; init; }

    [DomainSearch(
        "Deductible literal",
        "Literal text for the deductible.",
        Aliases = ["CB-FRANQUIA-CHAR", "BGOW9064-CB-FRANQUIA-CHAR"],
        Tags = ["field", "coverage", "deductible"])]
    public string? DeductibleText { get; init; }

    [DomainSearch(
        "Insured capital",
        "Coverage insured capital amount.",
        Aliases = ["CB-VALOR-CAP-SEG", "BGOW9064-CB-VALOR-CAP-SEG"],
        Tags = ["field", "coverage", "amount"])]
    public string? InsuredCapital { get; init; }
}

[DomainSearch(
    "Coverage deductible",
    "Reusable deductible and indemnity-limit detail for an insurance coverage.",
    Aliases = ["deductible", "franquia", "limite indemnizacao", "CB-COD-FRANQUIA"],
    Tags = ["common", "coverage", "deductible"])]
public sealed class CoverageDeductible
{
    [DomainSearch(
        "Deductible type",
        "Deductible type indicator.",
        Aliases = ["CB-COD-FRANQUIA", "BGOW9064-CB-COD-FRANQUIA"],
        Tags = ["field", "coverage", "deductible"])]
    public string? TypeCode { get; init; }

    [DomainSearch(
        "Deductible value",
        "Deductible amount.",
        Aliases = ["CB-VALOR-FRANQUIA", "BGOW9064-CB-VALOR-FRANQUIA"],
        Tags = ["field", "coverage", "deductible", "amount"])]
    public string? Value { get; init; }

    [DomainSearch(
        "Maximum deductible value",
        "Maximum deductible amount.",
        Aliases = ["CB-VALOR-MAX-FRANQ", "BGOW9064-CB-VALOR-MAX-FRANQ"],
        Tags = ["field", "coverage", "deductible", "amount"])]
    public string? MaximumValue { get; init; }

    [DomainSearch(
        "Deductible percentage",
        "Deductible percentage.",
        Aliases = ["CB-PERC-FRANQUIA", "BGOW9064-CB-PERC-FRANQUIA"],
        Tags = ["field", "coverage", "deductible"])]
    public string? Percentage { get; init; }

    [DomainSearch(
        "Deductible days",
        "Number of deductible days.",
        Aliases = ["CB-NUMERO-DIAS", "BGOW9064-CB-NUMERO-DIAS"],
        Tags = ["field", "coverage", "deductible"])]
    public string? Days { get; init; }

    [DomainSearch(
        "Indemnity limit type",
        "Indemnity-limit type indicator.",
        Aliases = ["CB-IND-LIM-INDMN", "BGOW9064-CB-IND-LIM-INDMN"],
        Tags = ["field", "coverage", "limit"])]
    public string? IndemnityLimitTypeCode { get; init; }

    [DomainSearch(
        "Indemnity limit value",
        "Indemnity-limit amount.",
        Aliases = ["CB-VALOR-LIM-INDMN", "BGOW9064-CB-VALOR-LIM-INDMN"],
        Tags = ["field", "coverage", "limit", "amount"])]
    public string? IndemnityLimitValue { get; init; }

    [DomainSearch(
        "Indemnity limit percentage",
        "Indemnity-limit percentage.",
        Aliases = ["CB-PERC-LIM-INDMN", "BGOW9064-CB-PERC-LIM-INDMN"],
        Tags = ["field", "coverage", "limit"])]
    public string? IndemnityLimitPercentage { get; init; }

    [DomainSearch(
        "Indemnity limit days",
        "Number of indemnity-limit days.",
        Aliases = ["CB-DIAS-LIM-INDMN", "BGOW9064-CB-DIAS-LIM-INDMN"],
        Tags = ["field", "coverage", "limit"])]
    public string? IndemnityLimitDays { get; init; }

    [DomainSearch(
        "Annual indemnity limit value",
        "Annual indemnity-limit amount.",
        Aliases = ["CB-VLR1-LIM-INDMN", "BGOW9064-CB-VLR1-LIM-INDMN"],
        Tags = ["field", "coverage", "limit", "amount"])]
    public string? AnnualIndemnityLimitValue { get; init; }
}
