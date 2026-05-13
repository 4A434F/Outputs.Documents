using Outputs.Documents.Domain;

namespace Outputs.Documents.Domain.Doce;

public class RegTicketPage : IDocumentModel
{
    public SingleRegisterTicket? Ticket1 { get; set; }
    public SingleRegisterTicket? Ticket2 { get; set; }
    public SingleRegisterTicket? Ticket3 { get; set; }
    public SingleRegisterTicket? Ticket4 { get; set; }
}
