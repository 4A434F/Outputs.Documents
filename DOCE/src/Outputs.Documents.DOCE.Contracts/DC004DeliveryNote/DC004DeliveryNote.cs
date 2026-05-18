using Outputs.Documents.Domain.Documents;
using Outputs.Documents.Domain.Locations;
using Outputs.Documents.Domain.Documents.Primitives;

namespace Outputs.Documents.DOCE.Contracts;

[DomainSearch(
    "DC004 Delivery Note",
    "DOCE delivery note contract with header, recipient address, generic table, delivery note number, date, and footer.",
    Aliases = ["delivery note", "nota entrega", "bordero", "delivery document"],
    Tags = ["contract", "doce", "DC004", "delivery-note"])]
public class DC004DeliveryNote : IDocumentModel
{
    public Header? Header { get; set; }
    public PostalAddress? Address { get; set; }
    public GenericTable Table { get; set; } = new()
    {
        Format = new GenericTableFormat
        {
            FontSize = "6pt",
            HeaderFontSize = "8pt",
            FontFamily = "Arial",
            CellPadding = "2px 6px",
            HeaderPadding = "2px 6px",
            RowHeight = "15px",
            LineHeight = "1.2",
            GridStyle = GenericTableGridStyle.HorizontalLines,
            OuterBorder = "none",
            HeaderBackground = "transparent",
        },
        Columns =
        [
            new() { Header = "Ramo / Produto", Width = "26%", CellAlign = ColumnAlign.Left, HeaderAlign = ColumnAlign.Left },
            new() { Header = "Nº da apólice", Width = "14%", CellAlign = ColumnAlign.Left, HeaderAlign = ColumnAlign.Center },
            new() { Header = "Nº do recibo", Width = "14%", CellAlign = ColumnAlign.Left, HeaderAlign = ColumnAlign.Center },
            new() { Header = "Tipo de recibo", Width = "10%", CellAlign = ColumnAlign.Left, HeaderAlign = ColumnAlign.Center },
            new() { Header = "Valor do recibo", Width = "15%", CellAlign = ColumnAlign.Right, HeaderAlign = ColumnAlign.Center, Format = "N2" },
            new() { Header = "Valor de comissão", Width = "15%", CellAlign = ColumnAlign.Right, HeaderAlign = ColumnAlign.Center, Format = "N2" }
        ]
    };

    public string? DeliveryNoteNumber { get; set; }
    public DateTime Date { get; set; }
    public string? AgentNumber { get; set; }
    public Footer Footer { get; set; } = new();
}
