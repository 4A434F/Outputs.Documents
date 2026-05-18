namespace Outputs.Documents.Domain.Documents.Primitives;

[DomainSearch(
    "Generic table",
    "Reusable document table primitive with column definitions, row data, totals, and formatting.",
    Aliases = ["table", "custom table", "document table"],
    Tags = ["common", "primitive", "table"])]
public class GenericTable
{
    public GenericTableFormat Format { get; set; } = new();

    public List<CustomTableColumn> Columns { get; set; } = [];

    public List<CustomTableRow> Rows { get; set; } = [];

    public List<CustomTableRow> TotalsLabel { get; set; } = [];
}

public enum GenericTableGridStyle
{
    HorizontalLines,
    FullGrid,
    None
}

[DomainSearch(
    "Generic table format",
    "Reusable formatting options for generic document table rendering.",
    Aliases = ["table format", "table styling", "grid format"],
    Tags = ["common", "primitive", "table", "format"])]
public sealed class GenericTableFormat
{
    public string FontSize { get; set; } = "10pt";
    public string? HeaderFontSize { get; set; }
    public string FontFamily { get; set; } = "Arial";
    public string CellPadding { get; set; } = "4px 6px";
    public string HeaderPadding { get; set; } = "6px 6px";
    public string RowHeight { get; set; } = "22px";
    public string LineHeight { get; set; } = "1.2";
    public string RuleInset { get; set; } = "6px";
    public int TotalsValueColumns { get; set; } = 2;
    public GenericTableGridStyle GridStyle { get; set; } = GenericTableGridStyle.HorizontalLines;
    public string RowRule { get; set; } = "1px solid #cfcfcf";
    public string HeaderRule { get; set; } = "1px solid #cfcfcf";
    public string OuterBorder { get; set; } = "none";
    public string CellBorder { get; set; } = "1px dotted #000";
    public string HeaderBackground { get; set; } = "transparent";
    public bool Zebra { get; set; }
}

public enum ColumnAlign
{
    Left,
    Right,
    Center
}

[DomainSearch(
    "Custom table column",
    "Reusable table column definition with header, width, alignment, sum, and value formatting.",
    Aliases = ["table column", "column definition"],
    Tags = ["common", "primitive", "table", "column"])]
public sealed class CustomTableColumn
{
    public string Header { get; set; } = string.Empty;
    public string? Width { get; set; }
    public ColumnAlign HeaderAlign { get; set; } = ColumnAlign.Left;
    public ColumnAlign CellAlign { get; set; } = ColumnAlign.Left;
    public bool Sum { get; set; }
    public string? Format { get; set; }
}

[DomainSearch(
    "Custom table row",
    "Reusable DOCE table row carrying ordered cell values.",
    Aliases = ["table row", "row values"],
    Tags = ["common", "primitive", "table", "row"])]
public sealed class CustomTableRow
{
    public List<object?> Cells { get; set; } = [];
}
