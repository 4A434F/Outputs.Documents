using Outputs.Documents.Components.Tables;
using Outputs.Documents.Domain.Documents.Primitives;

namespace Outputs.Documents.Dashboard.Components.ComponentPreview;

public static class ComponentSampleCatalog
{
    public static IReadOnlyList<ComponentSampleDescriptor> All { get; } =
    [
        CreateValueTableSample(
            key: "document-value-table.header-underline",
            name: "Header underline",
            description: "Compact receipt table with a single header rule.",
            style: DocumentValueTableStyle.HeaderUnderline),
        CreateValueTableSample(
            key: "document-value-table.horizontal-lines",
            name: "Horizontal lines",
            description: "Generic table-style inset row rules.",
            style: DocumentValueTableStyle.HorizontalLines),
        CreateValueTableSample(
            key: "document-value-table.grid",
            name: "Grid",
            description: "Generic table-style dotted full grid.",
            style: DocumentValueTableStyle.Grid),
        CreateValueTableSample(
            key: "document-value-table.none",
            name: "No borders",
            description: "Plain values with table layout only.",
            style: DocumentValueTableStyle.None)
    ];

    private static ComponentSampleDescriptor CreateValueTableSample(
        string key,
        string name,
        string description,
        DocumentValueTableStyle style)
    {
        return new ComponentSampleDescriptor
        {
            Key = key,
            Name = name,
            Group = "Tables",
            Description = description,
            PageSize = "A4",
            ComponentType = typeof(DocumentValueTableComponent),
            Parameters = new Dictionary<string, object?>
            {
                [nameof(DocumentValueTableComponent.Data)] = new DocumentValueTable
                {
                    Rows =
                    [
                        new DocumentValueTableRow
                        {
                            Cells = ["88760389221", "13-mar-2026 a 12-abr-2026", "65,42"]
                        },
                        new DocumentValueTableRow
                        {
                            Cells = ["88760389222", "13-abr-2026 a 12-mai-2026", "65,42"]
                        }
                    ],
                    Totals =
                    [
                        new DocumentValueTableRow
                        {
                            Cells = ["Total", "", "12,84"]
                        }
                    ]
                },
                [nameof(DocumentValueTableComponent.ColumnDefinitions)] = new List<DocumentValueTableColumnDefinition>
                {
                    new("Nº Recibo", width: 30),
                    new("Período", ColumnAlign.Center, 45),
                    new("Valor (€)", ColumnAlign.Right, 25)
                },
                [nameof(DocumentValueTableComponent.Style)] = style
            }
        };
    }
}
