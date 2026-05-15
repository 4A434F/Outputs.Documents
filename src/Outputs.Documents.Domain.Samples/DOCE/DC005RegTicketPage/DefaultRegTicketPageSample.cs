using Outputs.Documents.Domain.Expedition;
using RegTicketPageContract = Outputs.Documents.Domain.Contracts.DOCE.DC005RegTicketPage;

namespace Outputs.Documents.Domain.Samples.DOCE.DC005RegTicketPage;

public sealed class DefaultRegTicketPageSample : IDocumentModelSample<RegTicketPageContract>
{
    public RegTicketPageContract Create()
    {
        return new RegTicketPageContract
        {
            Ticket1 = CreateTicket("Maria Silva", "RR000000001PT"),
            Ticket2 = CreateTicket("Empresa Exemplo, Lda.", "RR000000002PT"),
            Ticket3 = CreateTicket("Joao Pereira", "RR000000003PT"),
            Ticket4 = CreateTicket("Ana Costa", "RR000000004PT")
        };
    }

    private static SingleRegisterTicket CreateTicket(string name, string registrationCode)
    {
        return new SingleRegisterTicket
        {
            ClientName = "Fidelidade",
            ClientAddr1 = "Largo do Calhariz, 30",
            ClientAddr2 = "1249-001 Lisboa",
            Name = name,
            Addr1 = "Rua das Flores, 12",
            Addr2 = "1000-001 Lisboa",
            HorizontalRegCode = registrationCode
        };
    }
}
