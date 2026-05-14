using Outputs.Documents.Domain.Documents;
using Outputs.Documents.Domain.Entities;
using Outputs.Documents.Domain.Locations;
using Outputs.Documents.Domain.Policies;

namespace Outputs.Documents.Domain.Contracts.COGEN22;

[DomainSearch(
    "BGOW9068 contract",
    "COGEN22 contact and email change letter copybook contract.",
    Aliases = ["BGOW9068"],
    Tags = ["contract", "origin:COGEN22", "copybook:BGOW9068"])]
public sealed class BGOW9068Contract : IDocumentModel
{
    public const string OriginSystem = "COGEN22";

    public const string CopybookId = "BGOW9068";

    [DomainSearch(
        "Document identification",
        "Template/document selector for BGOW9068.",
        Aliases = ["1328", "BGOW9068"],
        Tags = ["field", "origin:COGEN22", "copybook:BGOW9068", "document-selector"])]
    public string DocumentIdentification { get; init; } = "1328";

    [DomainSearch(
        "DocumentInformation",
        "Document envelope and routing metadata identified in BGOW9068.",
        Aliases = ["BGOW9068", "COMPANY", "MARCA", "CLIENT-REFERENCE", "AGENTE-COBRADOR", "PRODUTO", "POLICY-NUMBER", "POLICY-TRANSACTION", "TIPO-DOC", "NUM-SEQ-1", "DATA-PROCESSAMENTO", "TIPO-IMPRESSAO"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9068", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Client",
        "Client entity and destination identity identified in BGOW9068.",
        Aliases = ["BGOW9068", "CLIENT-REFERENCE", "TM-ADDRESSEE", "POST-CODE", "TM-ADDRESS1", "TM-ADDRESS2", "TM-ADDRESS3", "TM-ADDRESS4", "TM-TNUM-PORTA", "TM-NUM-PORTA"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9068", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Agent",
        "Collecting mediator entity identified in BGOW9068.",
        Aliases = ["BGOW9068", "AGENTE-COBRADOR", "AG-POST-CODE"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9068", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "Mailing address",
        "Destination postal address identified in BGOW9068.",
        Aliases = ["BGOW9068", "TM-ADDRESSEE", "TM-ADDRESS1", "TM-ADDRESS2", "TM-ADDRESS3", "TM-ADDRESS4", "POST-CODE", "TM-TNUM-PORTA", "TM-NUM-PORTA"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9068", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Policy and product context identified in BGOW9068.",
        Aliases = ["BGOW9068", "POLICY-NUMBER", "POLICY-TRANSACTION", "PRODUTO", "PRODUCT"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9068", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Print payload control",
        "Typed printable payload control fields identified in BGOW9068.",
        Aliases = ["BGOW9068", "NUM-SEQ-1", "RECORD-TYPE-1", "RECORD-TYPE-2", "TYPE-1-2", "PRINT-DATA"],
        Tags = ["structure", "origin:COGEN22", "copybook:BGOW9068", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();


}
