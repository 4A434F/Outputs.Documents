using Outputs.Documents.Domain.Expedition;

namespace Outputs.Documents.Domain.Contracts.DOCE;

[DomainSearch(
    "DC005 Register Ticket Page",
    "DOCE registered-ticket page contract containing up to four reusable register ticket blocks.",
    Aliases = ["register ticket page", "registered ticket page", "postal ticket page"],
    Tags = ["contract", "doce", "DC005", "registered-mail", "ticket"])]
public class DC005RegTicketPage : IDocumentModel
{
    public SingleRegisterTicket? Ticket1 { get; set; }
    public SingleRegisterTicket? Ticket2 { get; set; }
    public SingleRegisterTicket? Ticket3 { get; set; }
    public SingleRegisterTicket? Ticket4 { get; set; }
}
