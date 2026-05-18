namespace Outputs.Documents.Domain.Documents.Primitives;

[DomainSearch(
    "Document value table",
    "Simple reusable document table with body cell values and optional totals. Column headers and layout are owned by the template.",
    Aliases = ["simple table", "value table", "table with totals"],
    Tags = ["common", "primitive", "table"])]
public sealed class DocumentValueTable
{
    public List<DocumentValueTableRow> Rows { get; set; } = [];

    public List<DocumentValueTableRow> Totals { get; set; } = [];
}

[DomainSearch(
    "Document value table row",
    "Ordered row of values for a simple document table.",
    Aliases = ["table row", "cell values"],
    Tags = ["common", "primitive", "table", "row"])]
public sealed class DocumentValueTableRow
{
    public List<object?> Cells { get; set; } = [];
}
