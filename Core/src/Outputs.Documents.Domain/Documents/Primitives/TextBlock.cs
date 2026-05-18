namespace Outputs.Documents.Domain.Documents.Primitives;

[DomainSearch(
    "Text block",
    "Reusable text-only block for notes, clauses, descriptions, and document free text.",
    Aliases = ["text block", "notas", "descricao", "NC-NOTAS-COB"],
    Tags = ["common", "text"])]
public sealed class TextBlock
{
    [DomainSearch(
        "Text",
        "Free text content.",
        Aliases = ["NC-NOTAS-COB", "BGOW9064-NC-NOTAS-COB"],
        Tags = ["field", "text"])]
    public string? Text { get; init; }
}
