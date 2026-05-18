using Outputs.Documents.Domain.Entities;
using Outputs.Documents.Domain.Payments;
using Outputs.Documents.Domain.Policies;
using Outputs.Documents.Domain.Policies.Risks;

namespace Outputs.Documents.FSCD.Contracts;

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

    [DomainSearch(
        "Client",
        "Client party and postal address used by BGOW0044 cancellation letters.",
        Aliases = ["BGOW0044-CL-NOME", "BGOW0044-CL-NIF", "BGOW0044-CL-MORADA1", "DADOS-CLIENTE"],
        Tags = ["field", "entity", "origin:FSCD", "copybook:BGOW0044"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Policy reference",
        "Policy, client, agent, and origin-system identifiers used by BGOW0044 cancellation letters.",
        Aliases = ["BGOW0044-NR-APOLICE", "BGOW0044-NR-CLIENTE", "BGOW0044-NR-AGENTE"],
        Tags = ["field", "policy", "origin:FSCD", "copybook:BGOW0044"])]
    public PolicyReference Policy { get; init; } = new();

    [DomainSearch(
        "Product reference",
        "Product, branch, and branch-product description used by BGOW0044 cancellation letters.",
        Aliases = ["BGOW0044-COD-PRODUTO", "BGOW0044-COD-RAMO", "BGOW0044-DESCR-RAMO-PROD"],
        Tags = ["field", "product", "origin:FSCD", "copybook:BGOW0044"])]
    public ProductReference Product { get; init; } = new();

    [DomainSearch(
        "Risk unit",
        "Insured object or risk-unit description used by BGOW0044 cancellation letters.",
        Aliases = ["BGOW0044-DADOS-UR", "BGOW0044-OS-OBJECTO-SEG", "BGOW0044-DO-OBJETO-SEG"],
        Tags = ["field", "risk", "origin:FSCD", "copybook:BGOW0044"])]
    public RiskUnit? RiskUnit { get; init; }

    [DomainSearch(
        "Issue date",
        "Document issue date used in the rendered letter date.",
        Aliases = ["BGOW0044-DT-EMISSAO", "DT-EMISSAO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? IssueDate { get; init; }

    [DomainSearch(
        "Cancellation date",
        "Date from which the policy cancellation takes effect.",
        Aliases = ["BGOW0044-DT-ANULACAO", "DT-ANULACAO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? CancellationDate { get; init; }

    [DomainSearch(
        "Debt amount",
        "Premium amount to pay after cancellation.",
        Aliases = ["BGOW0044-VLR-DIVIDA", "VLR-DIVIDA"],
        Tags = ["field", "amount", "origin:FSCD", "copybook:BGOW0044"])]
    public decimal? DebtAmount { get; init; }

    [DomainSearch(
        "ATM payment",
        "Portuguese ATM payment entity and reference for premium payment.",
        Aliases = ["BGOW0044-ATM-ENTIDADE", "BGOW0044-ATM-REF", "PG-ATM"],
        Tags = ["field", "payment", "origin:FSCD", "copybook:BGOW0044"])]
    public AtmPaymentReference? AtmPayment { get; init; }

    [DomainSearch(
        "Policyholder name",
        "Policyholder or insurance taker name used in life cancellation letters.",
        Aliases = ["BGOW0044-VA-NOME-TOMADOR", "VA-NOME-TOMADOR", "Tomador do Seguro"],
        Tags = ["field", "entity", "origin:FSCD", "copybook:BGOW0044"])]
    public string? PolicyholderName { get; init; }

    [DomainSearch(
        "Insured people",
        "People insured by the life policy and shown in the subject block.",
        Aliases = ["Pessoas Seguras", "BGOW0044-PSEGURA1-NOME", "BGOW0044-PSEGURA1-NIF", "BGOW0044-PSEGURA2-NOME", "BGOW0044-PSEGURA2-NIF"],
        Tags = ["field", "entity", "life", "origin:FSCD", "copybook:BGOW0044"])]
    public IReadOnlyList<Entity> InsuredPeople { get; init; } = [];

    [DomainSearch(
        "Beneficiary intervenor",
        "Beneficiary intervenor name shown in life cancellation letters.",
        Aliases = ["Beneficiário Interventor", "BGOW0044-CH-NOME", "BGOW0044-CH-NUMBER"],
        Tags = ["field", "entity", "life", "origin:FSCD", "copybook:BGOW0044"])]
    public string? BeneficiaryIntervenorName { get; init; }

    [DomainSearch(
        "Bank process",
        "Life additional bank process identifier shown in the subject block.",
        Aliases = ["BGOW0044-VA-PROC-BANC", "VA-PROC-BANC", "Processo Bancário"],
        Tags = ["field", "life", "origin:FSCD", "copybook:BGOW0044"])]
    public string? BankProcess { get; init; }

    [DomainSearch(
        "Due date",
        "Premium due date used in lack-of-payment letters.",
        Aliases = ["BGOW0044-VA-DT-VENCMNTO", "VA-DT-VENCMNTO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? DueDate { get; init; }

    [DomainSearch(
        "Payment limit date",
        "Final payment date used before automatic cancellation.",
        Aliases = ["BGOW0044-VA-DT-LIM-PAGTO", "VA-DT-LIM-PAGTO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? PaymentLimitDate { get; init; }

    [DomainSearch(
        "Receipt details",
        "Receipt rows listed in BGOW0044 lack-of-payment letters.",
        Aliases = ["BGOW0044-DETALHE-LISTA", "BGOW0044-LST-NR-RECIBO", "BGOW0044-LST-DT-INI-REC", "BGOW0044-LST-DT-FIM-REC", "BGOW0044-LST-VLR-RECIBO"],
        Tags = ["field", "receipt", "origin:FSCD", "copybook:BGOW0044"])]
    public IReadOnlyList<ReceiptDetail> ReceiptDetails { get; init; } = [];

    [DomainSearch(
        "Receipt detail",
        "Single receipt row used in BGOW0044 lack-of-payment letters.",
        Aliases = ["BGOW0044-LST-NR-RECIBO", "BGOW0044-LST-DT-INI-REC", "BGOW0044-LST-DT-FIM-REC", "BGOW0044-LST-VLR-RECIBO"],
        Tags = ["contract", "receipt", "origin:FSCD", "copybook:BGOW0044"])]
    public sealed class ReceiptDetail
    {
        [DomainSearch(
            "Receipt number",
            "Receipt number in the receipt detail list.",
            Aliases = ["BGOW0044-LST-NR-RECIBO", "LST-NR-RECIBO"],
            Tags = ["field", "receipt", "copybook:BGOW0044"])]
        public string? ReceiptNumber { get; init; }

        [DomainSearch(
            "Receipt start date",
            "Receipt start date in the receipt detail list.",
            Aliases = ["BGOW0044-LST-DT-INI-REC", "LST-DT-INI-REC"],
            Tags = ["field", "date", "receipt", "copybook:BGOW0044"])]
        public DateOnly? StartDate { get; init; }

        [DomainSearch(
            "Receipt end date",
            "Receipt end date in the receipt detail list.",
            Aliases = ["BGOW0044-LST-DT-FIM-REC", "LST-DT-FIM-REC"],
            Tags = ["field", "date", "receipt", "copybook:BGOW0044"])]
        public DateOnly? EndDate { get; init; }

        [DomainSearch(
            "Receipt amount",
            "Receipt amount in the receipt detail list.",
            Aliases = ["BGOW0044-LST-VLR-RECIBO", "LST-VLR-RECIBO"],
            Tags = ["field", "amount", "receipt", "copybook:BGOW0044"])]
        public decimal? Amount { get; init; }
    }
}
