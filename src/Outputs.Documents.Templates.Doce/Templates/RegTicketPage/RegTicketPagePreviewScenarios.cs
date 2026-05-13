using Outputs.Documents.Domain.Doce;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Templates.Doce;

public sealed class RegTicketPagePreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new("four-tickets", "Four registered tickets", typeof(RegTicketPage), RegTicketPage());
    }

    private static RegTicketPage RegTicketPage()
    {
        return new RegTicketPage
        {
            Ticket1 = RegisterTicket("1"),
            Ticket2 = RegisterTicket("2"),
            Ticket3 = RegisterTicket("3"),
            Ticket4 = RegisterTicket("4")
        };
    }

    private static SingleRegisterTicket RegisterTicket(string suffix)
    {
        return new SingleRegisterTicket
        {
            ClientName = $"MARIA ISABEL MANATA SILVA {suffix}",
            ClientAddr1 = "R PADRAO 11 ARRANCADA",
            ClientAddr2 = "3060-311 FEBRES",
            ClientAddr3 = "3060-311 FEBRES",
            ClientAddr4 = "3060-311 FEBRES",
            Name = "NOME REMETENTE XXXXXXXXXXXXXXXXXXXXXX",
            Addr1 = "MORADA DEST 1 XXXXXXXXXXXXXXXXXXXXXX",
            Addr2 = "MORADA DEST 2 XXXXXXXXXXXXXXXXXXXXXX",
            BarcodeBase64 = "iVBORw0KGgoAAAANSUhEUgAAAkQAAAA8CAYAAACHDqXfAAAACXBIWXMAAA7EAAAOxAGVKw4bAAABdElEQVR4nO3WywqCQABAUQX//5crAjdC+Mqi7jkbUcYZR13c6fYw8DXjOD6Py8+wvD6fz7ZePzpu7b6159x6vpzn7P6unnfr+3jXvHv/j3f9F7++ztnvctU6e+f91/f2atza/Xv3fXTdreusjTu7Tz5rGgAA4gQRAJAniACAPEEEAOQJIgAgTxABAHmCCADIE0QAQJ4gAgDyBBEAkCeIAIA8QQQA5AkiACBPEAEAeYIIAMgTRABAniACAPIEEQCQJ4gAgDxBBADkCSIAIE8QAQB5gggAyBNEAECeIAIA8gQRAJAniACAPEEEAOQJIgAgTxABAHmCCADIE0QAQJ4gAgDyBBEAkCeIAIA8QQQA5AkiACBPEAEAeYIIAMgTRABAniACAPIEEQCQJ4gAgDxBBADkCSIAIE8QAQB5gggAyBNEAECeIAIA8gQRAJAniACAPEEEAOQJIgAgTxABAHmCCADIE0QAQJ4gAgDyBBEAkCeIAIC8O0+S5e3i1p52AAAAAElFTkSuQmCC",
            HorizontalRegCode = "RG061224024PT"
        };
    }
}
