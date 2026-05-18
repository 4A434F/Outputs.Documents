namespace Outputs.Documents.Domain.Documents;

[DomainSearch(
    "Print payload record control",
    "Record-control and raw print payload markers for fixed-width document copybooks that split printable content into typed lines.",
    Aliases = ["RECORD-TYPE-1", "RECORD-TYPE-2", "TYPE-1-2", "PRINT-DATA", "NUM-SEQ-1"],
    Tags = ["common", "document", "print-payload", "record-control"])]
public sealed class PrintPayloadRecordControl
{
    [DomainSearch(
        "Sequence number",
        "Sequence number of the print payload record.",
        Aliases = ["NUM-SEQ-1", "BGOW9068-NUM-SEQ-1"],
        Tags = ["field", "document", "print-payload", "copybook:BGOW9068"])]
    public string? SequenceNumber { get; init; }

    [DomainSearch(
        "Primary record type",
        "Primary record type marker for a fixed-width document print payload record.",
        Aliases = ["RECORD-TYPE-1", "BGOW9068-RECORD-TYPE-1"],
        Tags = ["field", "document", "print-payload", "copybook:BGOW9068"])]
    public string? PrimaryRecordType { get; init; }

    [DomainSearch(
        "Secondary record type",
        "Secondary record type marker for a fixed-width document print payload record.",
        Aliases = ["RECORD-TYPE-2", "BGOW9068-RECORD-TYPE-2"],
        Tags = ["field", "document", "print-payload", "copybook:BGOW9068"])]
    public string? SecondaryRecordType { get; init; }

    [DomainSearch(
        "Composite record type",
        "Composite record type formed from the print payload record type fragments.",
        Aliases = ["TYPE-1-2", "BGOW9068-TYPE-1-2"],
        Tags = ["field", "document", "print-payload", "copybook:BGOW9068"])]
    public string? CompositeRecordType { get; init; }

    [DomainSearch(
        "Raw print data",
        "Raw printable data area carried by the fixed-width document payload record.",
        Aliases = ["PRINT-DATA", "BGOW9068-PRINT-DATA"],
        Tags = ["field", "document", "print-payload", "copybook:BGOW9068"])]
    public string? RawPrintData { get; init; }
}
