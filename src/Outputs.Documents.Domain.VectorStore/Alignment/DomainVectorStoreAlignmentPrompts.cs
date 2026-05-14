namespace Outputs.Documents.Domain.VectorStore.Alignment;

public static class DomainVectorStoreAlignmentPrompts
{
    public static IReadOnlyList<AlignmentPrompt> All { get; } =
    [
        new("address", "Postal address for a recipient."),
        new("policy", "Insurance policy number."),
        new("footer", "Document footer with legal text."),
        new("barcode", "Registered mail barcode."),
        new("payment", "Payment amount and transaction movement.")
    ];
}
