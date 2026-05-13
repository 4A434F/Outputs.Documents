using Outputs.Documents.Domain.Doce;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Templates.Doce;

public sealed class DeliveryNotePreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new("standard", "Standard delivery note", typeof(DeliveryNote), DeliveryNote());
    }

    private static DeliveryNote DeliveryNote()
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
}
