namespace Outputs.Documents.Domain.Documents.Primitives;

[DomainSearch(
    "Titled text block",
    "Reusable title and text block for conditions, clauses, notes, and document free text.",
    Aliases = ["titled text block", "condicoes gerais", "clausulas", "CG-CODIGO", "CG-DESCRITIVO"],
    Tags = ["common", "text"])]
public sealed class TitledTextBlock
{
    [DomainSearch(
        "Title",
        "Text block title or code.",
        Aliases = ["CG-CODIGO", "DC-TIPO-DEC-CLAUS", "BGOW9064-CG-CODIGO", "BGOW9064-DC-TIPO-DEC-CLAUS"],
        Tags = ["field", "text"])]
    public string? Title { get; init; }

    [DomainSearch(
        "Text",
        "Text block content.",
        Aliases = ["CG-DESCRITIVO", "DC-DESCRITIVO", "BGOW9064-CG-DESCRITIVO", "BGOW9064-DC-DESCRITIVO"],
        Tags = ["field", "text"])]
    public string? Text { get; init; }
}
