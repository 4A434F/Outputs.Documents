using Outputs.Documents.Domain.Payments;
using Outputs.Documents.Domain.Entities;
using Outputs.Documents.Domain.Policies;
using Outputs.Documents.Domain.Policies.Risks;

namespace Outputs.Documents.Domain.Contracts.FSCD;

[DomainSearch(
    "FS000 Cancelation Letter",
    "Single final FS cancellation letter contract proposed by BGOW0044 Novo Layout - Final. Legacy cancellation copybooks merge into this one domain model.",
    Aliases = ["FS000", "carta cancelamento", "BGOW0044", "cancellation letter", "cancelation letter"],
    Tags = ["contract", "area:FS", "origin:FSCD", "document:cancelation-letter", "copybook:BGOW0044"])]
public sealed class FS000CancelationLetter : IDocumentModel
{
    public const string Area = "FS";

    public const int Number = 0;

    public const string ContractId = "FS000";

    [DomainSearch(
        "Document identification",
        "Four-character Outputs document identification used to select the concrete FS cancellation letter template.",
        Aliases = ["DocumentId", "DocumentIdentification", "1037", "1038", "1039", "1040", "1041", "1042", "1043", "1044", "1045", "1046", "1047", "1176", "1177", "1178", "1179", "1180", "1181", "1182", "1183", "1184", "1185"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0044"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "Document code",
        "Cancellation document type code from BGOW0044.",
        Aliases = ["BGOW0044-COD-DOCUMENTO", "COD-DOCUMENTO", "CDC1", "ENTI", "ENT1", "ENT2", "CTAD", "CHIP", "FP01", "FP02", "FP03", "FP04", "FP05", "FP06", "FP07", "FP12", "FP21", "FP23"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? DocumentCode { get; init; }

    [DomainSearch(
        "Record type",
        "BGOW0044 record type for document, receipt detail, or receipt footer rows.",
        Aliases = ["BGOW0044-TIPO-REGISTO", "TIPO-REGISTO", "REG-TIPO1", "REG-TIPO2", "REG-TIPO3"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? RecordType { get; init; }

    [DomainSearch(
        "Print type",
        "BGOW0044 print channel indicator for online, immediate, or batch printing.",
        Aliases = ["BGOW0044-TIPO-IMPRESSAO", "TIPO-IMPRESSAO", "IMP-ONLINE", "IMP-BATCH"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? PrintType { get; init; }

    [DomainSearch(
        "Online print user",
        "User identifier used for online or immediate printing.",
        Aliases = ["BGOW0044-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? OnlinePrintUserId { get; init; }

    [DomainSearch(
        "Policy reference",
        "Policy, company, brand, agent, client, and origin-system identifiers from DADOS-REGISTO.",
        Aliases = ["BGOW0044-COD-COMPANHIA", "BGOW0044-COD-MARCA", "BGOW0044-AUX-MARCA", "BGOW0044-NR-AGENTE", "BGOW0044-NR-CLIENTE", "BGOW0044-NR-APOLICE", "BGOW0044-COD-ORIGEM", "BGOW0044-IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public PolicyReference Policy { get; init; } = new();

    [DomainSearch(
        "Cancellation document number",
        "BGOW0044 cancellation letter document number.",
        Aliases = ["BGOW0044-NR-DOCUMENTO", "NR-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? DocumentNumber { get; init; }

    [DomainSearch(
        "Issue type code",
        "Emission, alteration, renewal, adjustment, cancellation, or extract issue type.",
        Aliases = ["BGOW0044-TIPO-EMISSAO", "TIPO-EMISSAO", "EMI-NOVO-NEGOCIO", "EMI-ALTERACAO", "EMI-RENOVACAO", "EMI-CANCELAMENTO", "EMI-ENTREGA-EXTR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? IssueTypeCode { get; init; }

    [DomainSearch(
        "Product reference",
        "Currency, product, branch, and product-branch description.",
        Aliases = ["BGOW0044-COD-MOEDA", "BGOW0044-COD-PRODUTO", "BGOW0044-COD-RAMO", "BGOW0044-DESCR-RAMO-PROD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public ProductReference Product { get; init; } = new();

    [DomainSearch(
        "Cancellation reason",
        "BGOW0044 cancellation reason code.",
        Aliases = ["BGOW0044-COD-MOTIVO", "COD-MOTIVO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? CancelationReasonCode { get; init; }

    [DomainSearch(
        "Debit account",
        "Direct debit bank-account block from PG-DEBITO.",
        Aliases = ["BGOW0044-DEB-NOME-BANCO", "BGOW0044-DEB-IBAN", "BGOW0044-DEB-SWIFT", "PG-DEBITO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public BankAccount? DebitAccount { get; init; }

    [DomainSearch(
        "Client",
        "Client party block from DADOS-CLIENTE.",
        Aliases = ["BGOW0044-CL-NOME", "BGOW0044-CL-LOCATION-REF", "BGOW0044-CL-MORADA1", "BGOW0044-CL-MORADA2", "BGOW0044-CL-LOCALIDADE", "BGOW0044-CL-CPOSTAL", "BGOW0044-CL-CPOSTAL-DESC", "BGOW0044-CL-CPAIS", "BGOW0044-CL-CPAIS-DESC", "BGOW0044-CL-IDP", "BGOW0044-CL-NIF", "BGOW0044-CL-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Policy start date",
        "Policy start date.",
        Aliases = ["BGOW0044-DT-INI-APOL", "DT-INI-APOL"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? PolicyStartDate { get; init; }

    [DomainSearch(
        "Policy end date",
        "Policy end date.",
        Aliases = ["BGOW0044-DT-FIM-APOL", "DT-FIM-APOL"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? PolicyEndDate { get; init; }

    [DomainSearch(
        "Issue date",
        "Document issue date.",
        Aliases = ["BGOW0044-DT-EMISSAO", "DT-EMISSAO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? IssueDate { get; init; }

    [DomainSearch(
        "Cancellation date",
        "Cancellation date.",
        Aliases = ["BGOW0044-DT-ANULACAO", "DT-ANULACAO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? CancelationDate { get; init; }

    [DomainSearch(
        "Claim date",
        "Claim date.",
        Aliases = ["BGOW0044-DT-SINISTRO", "DT-SINISTRO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? ClaimDate { get; init; }

    [DomainSearch(
        "Debt amount",
        "Debt amount shown in cancellation payment contexts.",
        Aliases = ["BGOW0044-VLR-DIVIDA", "VLR-DIVIDA"],
        Tags = ["field", "amount", "origin:FSCD", "copybook:BGOW0044"])]
    public decimal? DebtAmount { get; init; }

    [DomainSearch(
        "Payment account",
        "Payment bank-account block from PG-CONTA.",
        Aliases = ["BGOW0044-CNT-NOME-BANCO", "BGOW0044-CNT-IBAN", "BGOW0044-CNT-SWIFT", "PG-CONTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public BankAccount? PaymentAccount { get; init; }

    [DomainSearch(
        "ATM payment",
        "ATM payment entity and reference block.",
        Aliases = ["BGOW0044-ATM-ENTIDADE", "BGOW0044-ATM-REF", "PG-ATM"],
        Tags = ["field", "payment", "origin:FSCD", "copybook:BGOW0044"])]
    public AtmPaymentReference? AtmPayment { get; init; }

    [DomainSearch(
        "Agent",
        "Agent or mediator party block from DADOS-AGENTE.",
        Aliases = ["BGOW0044-AG-NOME", "BGOW0044-AG-LOCATION-REF", "BGOW0044-AG-MORADA1", "BGOW0044-AG-MORADA2", "BGOW0044-AG-LOCALIDADE", "BGOW0044-AG-CPOSTAL", "BGOW0044-AG-CPOSTAL-DESC", "BGOW0044-AG-CPAIS", "BGOW0044-AG-CPAIS-DESC", "BGOW0044-AG-IDP", "BGOW0044-AG-TELEFONE", "BGOW0044-AG-TELEMOVEL", "BGOW0044-AG-EMAIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "Mortgage creditor count",
        "Number of mortgage creditors in the cancellation letter.",
        Aliases = ["BGOW0044-CH-QUANT", "CH-QUANT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public int? MortgageCreditorCount { get; init; }

    [DomainSearch(
        "Mortgage creditor",
        "Mortgage creditor party block from DADOS-CREDORHIP.",
        Aliases = ["BGOW0044-CH-NUMBER", "BGOW0044-CH-NOME", "BGOW0044-CH-LOCATION-REF", "BGOW0044-CH-MORADA1", "BGOW0044-CH-MORADA2", "BGOW0044-CH-LOCALIDADE", "BGOW0044-CH-CPOSTAL", "BGOW0044-CH-CPOSTAL-DESC", "BGOW0044-CH-CPAIS", "BGOW0044-CH-CPAIS-DESC", "BGOW0044-CH-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public Entity? MortgageCreditor { get; init; }

    [DomainSearch(
        "Risk unit",
        "Insured object or risk unit block selected by UR-TIPO.",
        Aliases = ["BGOW0044-UR-QUANT", "BGOW0044-UR-TIPO", "BGOW0044-DADOS-UR", "UR-GERAL", "UR-VIDARISCO", "UR-SAUDE", "UR-AUTOMOVEL", "UR-MULTIRISCO", "UR-AT"],
        Tags = ["field", "risk", "origin:FSCD", "copybook:BGOW0044"])]
    public RiskUnit? RiskUnit { get; init; }

    [DomainSearch(
        "Bank process",
        "Life additional bank process identifier.",
        Aliases = ["BGOW0044-VA-PROC-BANC", "VA-PROC-BANC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? BankProcess { get; init; }

    [DomainSearch(
        "Due date",
        "Life additional due date.",
        Aliases = ["BGOW0044-VA-DT-VENCMNTO", "VA-DT-VENCMNTO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? DueDate { get; init; }

    [DomainSearch(
        "Payment limit date",
        "Life additional payment-limit date.",
        Aliases = ["BGOW0044-VA-DT-LIM-PAGTO", "VA-DT-LIM-PAGTO"],
        Tags = ["field", "date", "origin:FSCD", "copybook:BGOW0044"])]
    public DateOnly? PaymentLimitDate { get; init; }

    [DomainSearch(
        "Policyholder name",
        "Policyholder name from VIDA-ADIC.",
        Aliases = ["BGOW0044-VA-NOME-TOMADOR", "VA-NOME-TOMADOR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0044"])]
    public string? PolicyholderName { get; init; }

    [DomainSearch(
        "Receipt details",
        "List of receipt detail records.",
        Aliases = ["BGOW0044-DETALHE-LISTA", "BGOW0044-LST-NR-RECIBO", "BGOW0044-LST-DT-INI-REC", "BGOW0044-LST-DT-FIM-REC", "BGOW0044-LST-DT-DEVIDO", "BGOW0044-LST-VLR-RECIBO"],
        Tags = ["field", "receipt", "origin:FSCD", "copybook:BGOW0044"])]
    public IReadOnlyList<ReceiptDetail> ReceiptDetails { get; init; } = [];

    [DomainSearch(
        "Receipt list footer",
        "Receipt-list total footer.",
        Aliases = ["BGOW0044-FOOTER-LISTA", "BGOW0044-FTR-TOT-RECIBO"],
        Tags = ["field", "receipt", "footer", "origin:FSCD", "copybook:BGOW0044"])]
    public ReceiptFooter? ReceiptListFooter { get; init; }

    [DomainSearch(
        "Cancelation receipt detail",
        "Repeating receipt-list detail record for cancelation letters.",
        Aliases = ["detalhe lista recibos", "recibo", "lista recibos", "BGOW0044-DETALHE-LISTA"],
        Tags = ["contract", "receipt", "list", "copybook:BGOW0044"])]
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
            "Receipt due date",
            "Receipt due date in the receipt detail list.",
            Aliases = ["BGOW0044-LST-DT-DEVIDO", "LST-DT-DEVIDO"],
            Tags = ["field", "date", "receipt", "copybook:BGOW0044"])]
        public DateOnly? DueDate { get; init; }

        [DomainSearch(
            "Receipt amount",
            "Receipt amount in the receipt detail list.",
            Aliases = ["BGOW0044-LST-VLR-RECIBO", "LST-VLR-RECIBO"],
            Tags = ["field", "amount", "receipt", "copybook:BGOW0044"])]
        public decimal? Amount { get; init; }
    }

    [DomainSearch(
        "Cancelation receipt footer",
        "Footer record for the receipt list in cancelation letters.",
        Aliases = ["footer lista recibos", "total recibos", "BGOW0044-FOOTER-LISTA"],
        Tags = ["contract", "receipt", "footer", "copybook:BGOW0044"])]
    public sealed class ReceiptFooter
    {
        [DomainSearch(
            "Receipt total amount",
            "Total amount for the receipt footer.",
            Aliases = ["BGOW0044-FTR-TOT-RECIBO", "FTR-TOT-RECIBO"],
            Tags = ["field", "amount", "receipt", "copybook:BGOW0044"])]
        public decimal? TotalAmount { get; init; }
    }
}
