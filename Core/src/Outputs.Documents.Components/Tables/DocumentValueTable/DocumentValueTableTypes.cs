using Outputs.Documents.Domain.Documents.Primitives;

namespace Outputs.Documents.Components.Tables;

public enum DocumentValueTableStyle
{
    None,
    HeaderUnderline,
    HorizontalLines,
    Rows = HorizontalLines,
    Grid
}

public sealed class DocumentValueTableColumnDefinition
{
    public DocumentValueTableColumnDefinition()
    {
    }

    public DocumentValueTableColumnDefinition(
        string header,
        ColumnAlign alignment = ColumnAlign.Left,
        int? width = null)
    {
        Header = header;
        Alignment = alignment;
        Width = width;
    }

    public string Header { get; set; } = string.Empty;

    public ColumnAlign Alignment { get; set; } = ColumnAlign.Left;

    public int? Width { get; set; }

    internal string AlignmentClass => Alignment switch
    {
        ColumnAlign.Center => "center",
        ColumnAlign.Right => "right",
        _ => "left"
    };

    internal string? WidthStyle => Width is null
        ? null
        : $"width:{Width}%";
}
