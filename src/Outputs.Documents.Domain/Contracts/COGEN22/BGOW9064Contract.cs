using Outputs.Documents.Domain.Documents;
using Outputs.Documents.Domain.Documents.Primitives;
using Outputs.Documents.Domain.Entities;
using Outputs.Documents.Domain.Locations;
using Outputs.Documents.Domain.Policies;
using Outputs.Documents.Domain.Policies.Coverages;
using Outputs.Documents.Domain.Policies.Risks;

namespace Outputs.Documents.Domain.Contracts.COGEN22;

[DomainSearch(
    "BGOW9064 contract",
    "COGEN22 Tailor aggregate plan particular conditions copybook contract.",
    Aliases = ["BGOW9064"],
    Tags = ["contract", "origin:COGEN22", "copybook:BGOW9064"])]
public sealed class BGOW9064Contract : IDocumentModel
{
    public const string OriginSystem = "COGEN22";

    public const string CopybookId = "BGOW9064";

    [DomainSearch(
        "Document identification",
        "Template/document selector for BGOW9064.",
        Aliases = ["1327", "BGOW9064"],
        Tags = ["field", "origin:COGEN22", "copybook:BGOW9064", "document-selector"])]
    public string DocumentIdentification { get; init; } = "1327";

    [DomainSearch(
        "DocumentInformation",
        "Document routing and metadata identified in BGOW9064 DADOS-REGISTO.",
        Aliases = ["BGOW9064", "DADOS-REGISTO", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "DOC-NR", "DOC-SEQREG-NR", "COD-ORIGEM", "IND-FLYER"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "PostalAddress",
        "Postal destination identified in BGOW9064 DADOS-MORADA.",
        Aliases = ["BGOW9064", "DADOS-MORADA", "MR-NOME", "MR-LOCATION-REF", "MR-MORADA1", "MR-MORADA2", "MR-LOCALIDADE", "MR-CPOSTAL", "MR-CPOSTAL-DESC", "MR-CPAIS", "MR-CPAIS-DESC", "MR-IDP"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "address"])]
    public PostalAddress PostalAddress { get; init; } = new();

    [DomainSearch(
        "Entity",
        "Client identity identified in BGOW9064 DADOS-CLIENTE.",
        Aliases = ["BGOW9064", "DADOS-CLIENTE", "CL-NOME", "CL-NIF", "CL-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "entity"])]
    public Entity Entity { get; init; } = new();

    [DomainSearch(
        "Premium",
        "Premium values identified in BGOW9064 DADOS-VALOR.",
        Aliases = ["BGOW9064", "DADOS-VALOR", "DV-PREMIO-COM", "DV-ENCARGOS", "DV-PREMIO-TOT", "DV-PREMIO-COM-AD", "DV-ENCARGOS-AD", "DV-PREMIO-TOT-AD", "DV-PREMIO-COM-1F", "DV-ENCARGOS-1F", "DV-PREMIO-TOT-1F", "DV-PREMIO-COM-FS", "DV-ENCARGOS-FS", "DV-PREMIO-TOT-FS"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "premium"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "RiskUnit",
        "Insured object and risk detail identified in BGOW9064.",
        Aliases = ["BGOW9064", "OBJECTO-SEGURO", "OS-OBJECTO-SEG", "OS-LOCAL-RISC1", "OS-LOCAL-RISC2", "OS-CAPITAL-SEG", "PR-PRODUTO", "DO-PRODUTO", "DO-APOLICE", "DO-OBJETO-SEG", "DO-ACTIVIDADE", "DO-MODALIDADE", "DO-AMBITO-COB", "DO-LOCAL-RISC", "DO-NR-TRABALH"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "risk"])]
    public RiskUnit RiskUnit { get; init; } = new();

    [DomainSearch(
        "Coverages",
        "Coverage rows identified in BGOW9064 COBERTURAS.",
        Aliases = ["BGOW9064", "COBERTURAS", "CB-TIPO-COBERTURA", "CB-COD-COB", "CB-DESC-COB", "CB-TIPO-TABELA", "CB-COD-FRANQUIA", "CB-VALOR-FRANQUIA", "CB-VALOR-MAX-FRANQ", "CB-PERC-FRANQUIA", "CB-NUMERO-DIAS", "CB-IND-LIM-INDMN", "CB-VALOR-LIM-INDMN", "CB-PERC-LIM-INDMN", "CB-DIAS-LIM-INDMN", "CB-VLR1-LIM-INDMN", "CB-FRANQUIA-CHAR", "CB-VALOR-CAP-SEG"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "coverage"])]
    public IReadOnlyList<Coverage> Coverages { get; init; } = [];

    [DomainSearch(
        "Coverage notes",
        "Generic coverage note text blocks from BGOW9064.",
        Aliases = ["BGOW9064", "NC-NOTAS-COB"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "text"])]
    public IReadOnlyList<TextBlock> CoverageNotes { get; init; } = [];

    [DomainSearch(
        "General conditions",
        "Titled text blocks for BGOW9064 general conditions.",
        Aliases = ["BGOW9064", "CG-CODIGO", "CG-DESCRITIVO"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "text"])]
    public IReadOnlyList<TitledTextBlock> GeneralConditions { get; init; } = [];

    [DomainSearch(
        "Particular clauses",
        "Titled and subtitled clause text blocks from BGOW9064 declarations and clauses.",
        Aliases = ["BGOW9064", "DC-TIPO-DEC-CLAUS", "DC-DESCRITIVO"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9064", "text"])]
    public IReadOnlyList<TitledSubtitleTextBlock> ParticularClauses { get; init; } = [];

    [DomainSearch(
        "TIPO-REGISTO",
        "Tipo de registo",
        Aliases = ["BGOW9064", "BGOW9064-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:COGEN22", "copybook:BGOW9064"])]
    public string? TipoRegisto { get; init; }

}
