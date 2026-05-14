namespace Outputs.Documents.Domain.Contracts.FSCD;

[DomainSearch(
    "BGOW0044 contract",
    "Raw FSCD cancellation-letter relation contract from the BGOW0044 worksheet in merged_copybooks.xlsx.",
    Aliases = ["BGOW0044"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0044"])]
public sealed class BGOW0044Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0044";

    [DomainSearch(
        "Task",
        "Task identifier from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-TAREFA", "Tarefa"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? Task { get; init; }

    [DomainSearch(
        "Description",
        "Document description from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-DESCRICAO", "Descrição"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? Description { get; init; }

    [DomainSearch(
        "Primary program",
        "Primary program from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-PROGRAMAS", "Programas"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? PrimaryProgram { get; init; }

    [DomainSearch(
        "Secondary program",
        "Secondary program column from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-PROGRAMAS-2", "Programas"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? SecondaryProgram { get; init; }

    [DomainSearch(
        "Primary copybook",
        "Primary related copybook from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-COPYBOOKS", "Copybooks"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? PrimaryCopybook { get; init; }

    [DomainSearch(
        "Document layout code",
        "Document layout or X-code value from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-LAYOUT-CODE", "X-code"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? LayoutCode { get; init; }

    [DomainSearch(
        "Secondary copybook",
        "Secondary related copybook from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-COPYBOOKS-2", "Copybooks"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? SecondaryCopybook { get; init; }

    [DomainSearch(
        "Output prefix",
        "Output prefix value from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-PREFIXO", "Prefixo"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? OutputPrefix { get; init; }

    [DomainSearch(
        "Status",
        "Migration status from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-SITUACAO", "Situação"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? Status { get; init; }

    [DomainSearch(
        "Document identification",
        "Document identification values listed in the CHAPAO NOVO column of the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-CHAPAO-NOVO", "CHAPAO NOVO", "1006", "1040", "1023", "1090"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0044"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "Primary overlays",
        "First overlay notes column from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-OVERLAYS", "Overlays a replicar"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? PrimaryOverlays { get; init; }

    [DomainSearch(
        "Secondary overlays",
        "Second overlay notes column from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-OVERLAYS-2", "Overlays a replicar"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? SecondaryOverlays { get; init; }

    [DomainSearch(
        "Tertiary overlays",
        "Third overlay notes column from the BGOW0044 worksheet.",
        Aliases = ["BGOW0044", "BGOW0044-OVERLAYS-3", "Overlays a replicar"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? TertiaryOverlays { get; init; }
}
