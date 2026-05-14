namespace Outputs.Documents.Domain.Documents.Primitives;

[DomainSearch(
    "Titled subtitle text block",
    "Reusable title, subtitle, and text block for richer clauses, notes, and document free text.",
    Aliases = ["titled subtitle text block", "title subtitle text", "clause text"],
    Tags = ["common", "text"])]
public sealed class TitledSubtitleTextBlock
{
    [DomainSearch(
        "Title",
        "Text block title.",
        Aliases = ["title", "titulo"],
        Tags = ["field", "text"])]
    public string? Title { get; init; }

    [DomainSearch(
        "Subtitle",
        "Text block subtitle.",
        Aliases = ["subtitle", "subtitulo"],
        Tags = ["field", "text"])]
    public string? Subtitle { get; init; }

    [DomainSearch(
        "Text",
        "Text block content.",
        Aliases = ["text", "descricao", "descritivo"],
        Tags = ["field", "text"])]
    public string? Text { get; init; }
}
