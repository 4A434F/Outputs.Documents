namespace Outputs.Documents.Domain.Documents;

[DomainSearch(
    "Document information",
    "Reusable document information with document, print, company, brand, client, policy, and origin identifiers.",
    Aliases = ["document information", "registration header", "document envelope", "DADOS-REGISTO", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "TIPO-DOC"],
    Tags = ["common", "document", "information"])]
public sealed class DocumentInformation
{
    [DomainSearch(
        "Document code",
        "Document code sent by the origin system.",
        Aliases = ["COD-DOCUMENTO", "BGOW9064-COD-DOCUMENTO"],
        Tags = ["field", "document", "header"])]
    public string? DocumentCode { get; init; }

    [DomainSearch(
        "Print type",
        "Print channel or print mode identifier.",
        Aliases = ["TIPO-IMPRESSAO", "BGOW9064-TIPO-IMPRESSAO", "BGOW9068-TIPO-IMPRESSAO"],
        Tags = ["field", "document", "header"])]
    public string? PrintType { get; init; }

    [DomainSearch(
        "Document type code",
        "Document type code used by origin systems that expose a document category separately from the template/document identifier.",
        Aliases = ["TIPO-DOC", "BGOW9068-TIPO-DOC"],
        Tags = ["field", "document", "header", "copybook:BGOW9068"])]
    public string? DocumentTypeCode { get; init; }

    [DomainSearch(
        "Online user id",
        "User identifier for online or immediate printing.",
        Aliases = ["USERID", "BGOW9064-USERID"],
        Tags = ["field", "document", "header"])]
    public string? UserId { get; init; }

    [DomainSearch(
        "Company code",
        "Company identifier.",
        Aliases = ["COD-COMPANHIA", "BGOW9064-COD-COMPANHIA", "COMPANY", "BGOW9068-COMPANY"],
        Tags = ["field", "document", "header"])]
    public string? CompanyCode { get; init; }

    [DomainSearch(
        "Brand code",
        "Brand identifier.",
        Aliases = ["COD-MARCA", "BGOW9064-COD-MARCA", "MARCA", "BGOW9068-MARCA"],
        Tags = ["field", "document", "header"])]
    public string? BrandCode { get; init; }

    [DomainSearch(
        "Agent number",
        "Agent or mediator number.",
        Aliases = ["NR-AGENTE", "BGOW9064-NR-AGENTE", "AGENTE-COBRADOR", "BGOW9068-AGENTE-COBRADOR"],
        Tags = ["field", "document", "header"])]
    public string? AgentNumber { get; init; }

    [DomainSearch(
        "Client number",
        "Client identifier.",
        Aliases = ["NR-CLIENTE", "BGOW9064-NR-CLIENTE", "CLIENT-REFERENCE", "BGOW9068-CLIENT-REFERENCE"],
        Tags = ["field", "document", "header"])]
    public string? ClientNumber { get; init; }

    [DomainSearch(
        "Policy number",
        "Policy identifier.",
        Aliases = ["NR-APOLICE", "BGOW9064-NR-APOLICE", "POLICY-NUMBER", "BGOW9068-POLICY-NUMBER"],
        Tags = ["field", "document", "header"])]
    public string? PolicyNumber { get; init; }

    [DomainSearch(
        "Policy transaction code",
        "Policy transaction identifier used by origin systems to identify the policy operation represented by the document.",
        Aliases = ["POLICY-TRANSACTION", "BGOW9068-POLICY-TRANSACTION"],
        Tags = ["field", "document", "header", "policy", "copybook:BGOW9068"])]
    public string? PolicyTransactionCode { get; init; }

    [DomainSearch(
        "Product code",
        "Insurance product code carried in the document information envelope.",
        Aliases = ["PRODUTO", "BGOW9068-PRODUTO", "COD-PRODUTO", "BGOW0044-COD-PRODUTO"],
        Tags = ["field", "document", "header", "product"])]
    public string? ProductCode { get; init; }

    [DomainSearch(
        "Origin document number",
        "Origin-system document number used for ordering or correlation.",
        Aliases = ["DOC-NR", "BGOW9064-DOC-NR"],
        Tags = ["field", "document", "header"])]
    public string? OriginDocumentNumber { get; init; }

    [DomainSearch(
        "Origin sequence number",
        "Origin-system record sequence number.",
        Aliases = ["DOC-SEQREG-NR", "BGOW9064-DOC-SEQREG-NR", "NUM-SEQ-1", "BGOW9068-NUM-SEQ-1"],
        Tags = ["field", "document", "header"])]
    public string? OriginSequenceNumber { get; init; }

    [DomainSearch(
        "Processing date",
        "Origin-system processing date for the generated document.",
        Aliases = ["DATA-PROCESSAMENTO", "BGOW9068-DATA-PROCESSAMENTO"],
        Tags = ["field", "document", "header", "copybook:BGOW9068"])]
    public string? ProcessingDate { get; init; }

    [DomainSearch(
        "Origin system code",
        "Origin-system identifier.",
        Aliases = ["COD-ORIGEM", "BGOW9064-COD-ORIGEM"],
        Tags = ["field", "document", "header"])]
    public string? OriginSystemCode { get; init; }

    [DomainSearch(
        "Flyer indicator",
        "Flyer inclusion indicator.",
        Aliases = ["IND-FLYER", "BGOW9064-IND-FLYER"],
        Tags = ["field", "document", "header"])]
    public string? FlyerIndicator { get; init; }
}
