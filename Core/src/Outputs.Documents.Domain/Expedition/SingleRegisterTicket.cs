namespace Outputs.Documents.Domain.Expedition;

[DomainSearch(
    "Single register ticket",
    "Reusable expedition registered-mail ticket block with client, address, barcode, and registration code fields.",
    Aliases = ["register ticket", "registered ticket", "postal ticket", "barcode ticket"],
    Tags = ["common", "expedition", "registered-mail", "ticket"])]
public class SingleRegisterTicket
{
    public string? ClientName { get; set; }
    public string? ClientAddr1 { get; set; }
    public string? ClientAddr2 { get; set; }
    public string? ClientAddr3 { get; set; }
    public string? ClientAddr4 { get; set; }
    public string? Name { get; set; }
    public string? Addr1 { get; set; }
    public string? Addr2 { get; set; }
    public string? BarcodeBase64 { get; set; }
    public string? HorizontalRegCode { get; set; }
}
