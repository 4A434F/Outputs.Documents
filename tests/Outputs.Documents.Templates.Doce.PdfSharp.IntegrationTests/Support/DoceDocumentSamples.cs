using Outputs.Documents.Domain.Doce;

namespace Outputs.Documents.Templates.Doce.PdfSharp.IntegrationTests.Support;

internal static class DoceDocumentSamples
{
    public static CoverPage CoverPageFull()
    {
        return new CoverPage(
            PostalObjectType: "Manual",
            SegmentNumber: "S001",
            Title: "Title Title Title Title",
            Description: "Description Description Description",
            ProviderCode: "CTT",
            Department: null,
            Addr1: null,
            Addr2: null,
            Addr3: null,
            Addr4: null,
            PaperType: "A4",
            TotalSheets: 300,
            TotalPrintedPages: 75,
            TotalPostalObjects: 100,
            DividerCount: null,
            TotalAdicional1: null,
            TotalAdicional2: null,
            TotalAdicional3: null,
            TotalAdicional4: null,
            TotalAdicional5: null,
            DocumentDate: new DateTime(2025, 7, 9, 14, 35, 50));
    }

    public static CoverPage CoverPageShort()
    {
        return new CoverPage(
            PostalObjectType: "DL",
            SegmentNumber: "S001",
            Title: "Title Title Title Title",
            Description: "Description Description Description",
            ProviderCode: "CTT",
            Department: "Department",
            Addr1: "Addr1Addr1Addr1Addr1Addr1Addr1Addr1",
            Addr2: "Addr2Addr2Addr2Addr2Addr2Addr2Addr2",
            Addr3: "Addr3Addr3Addr3Addr3Addr3Addr3Addr3",
            Addr4: "Addr4Addr4Addr4Addr4Addr4Addr4Addr4",
            PaperType: "A4",
            TotalSheets: 300,
            TotalPrintedPages: 75,
            TotalPostalObjects: 100,
            DividerCount: 6,
            TotalAdicional1: 12,
            TotalAdicional2: 1,
            TotalAdicional3: 1,
            TotalAdicional4: 13,
            TotalAdicional5: 14,
            DocumentDate: new DateTime(2025, 7, 9, 14, 35, 50));
    }

    public static CttDispatchSheet DispatchSheet()
    {
        var entries = Enumerable.Range(1, 25)
            .Select(index => new CttDispatchEntry(
                $"Recipient {index:00}",
                "Rua das Flores, 123",
                "1200-001",
                $"P-{index:000}",
                $"R-{index:000}"))
            .ToList();

        return new CttDispatchSheet(
            traceId: Trace(),
            authorizationLabel: "Autorizacao",
            authorizationCode: "AUTH-001",
            title: "Comprovativo de Envio",
            relationLabel: "Relacao",
            relationNumber: "REL-2025",
            date: "09-07-2025 14:35",
            employeeLabel: "EMP123",
            senderName: "Empresa XPTO",
            senderAddress: "Rua Central, 789",
            entries: entries);
    }

    public static Divider Divider()
    {
        return new Divider("Urgente");
    }

    public static DeliveryNote DeliveryNote()
    {
        var model = new DeliveryNote
        {
            Header = new Header("Fidelidade.png"),
            Address = Address(),
            Date = new DateTime(2025, 7, 9, 14, 35, 50),
            AgentNumber = "12345",
            TraceText = Trace(),
            Footer = new Footer()
        };

        model.Table.Rows =
        [
            new() { Cells = ["Trabalhador Independente", "AC65995787", "5134392350", "Estorno", "-45,82", "5,14"] },
            new() { Cells = ["Trabalhador Independente", "AC66087779", "0191741886", "Premio", "192,51", "22,53"] },
            new() { Cells = ["AUTO Tradicional", "753537407", "5134391862", "Estorno", "39,18", "3,70"] },
            new() { Cells = ["Liber 3G Particulares", "755123122", "5134398042", "Premio", "-66,96", "5,95"] }
        ];

        model.Table.TotalsLabel =
        [
            new() { Cells = ["Total de Premios", "", "", "", "669,81", "-70,09"] },
            new() { Cells = ["Total de Estornos", "", "", "", "-336,16", "-32,59"] },
            new() { Cells = ["TOTAL DOS MOVIMENTOS", "", "", "", "333,65", "-37,50"] }
        ];

        return model;
    }

    public static DoceCourtesyLetter CourtesyLetter()
    {
        return new DoceCourtesyLetter
        {
            Header = new Header("Fidelidade.png", "GUIA DE REMESSA 11111"),
            Address = Address(),
            Date = new DateTime(2025, 7, 9, 14, 35, 50),
            TraceText = Trace(),
            Footer = new Footer()
        };
    }

    public static RegTicketPage RegTicketPage()
    {
        return new RegTicketPage
        {
            Ticket1 = RegisterTicket("1"),
            Ticket2 = RegisterTicket("2"),
            Ticket3 = RegisterTicket("3"),
            Ticket4 = RegisterTicket("4")
        };
    }

    private static Address Address()
    {
        return new Address(
            "CARLOS ARRUDA SOC MEDIACAO SEGUROS LDA",
            "R ALMIRANTE GAGO COUTINHO 14 AP 25",
            "9680-117 VILA FRANCA CAMPO");
    }

    private static DocumentTraceId Trace()
    {
        return new DocumentTraceId
        {
            Line1 = "X004 07/11/2025 06:36:13",
            Line2 = "0000000004 1002 PGOC015A"
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
