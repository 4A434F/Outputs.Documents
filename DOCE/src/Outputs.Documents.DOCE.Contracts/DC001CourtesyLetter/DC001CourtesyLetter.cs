using Outputs.Documents.Domain.Documents;
using Outputs.Documents.Domain.Locations;

namespace Outputs.Documents.DOCE.Contracts;

[DomainSearch(
    "DC001 Courtesy Letter",
    "DOCE courtesy letter contract with header, recipient address, date, footer, and agent number.",
    Aliases = ["courtesy letter", "carta acompanhamento", "letter"],
    Tags = ["contract", "doce", "DC001", "letter"])]
public class DC001CourtesyLetter : IDocumentModel
{
    public Header? Header { get; set; }
    public PostalAddress? Address { get; set; }
    public DateTime Date { get; set; }
    public Footer Footer { get; set; } = new();
    public string? AgentNumber { get; set; }
}
