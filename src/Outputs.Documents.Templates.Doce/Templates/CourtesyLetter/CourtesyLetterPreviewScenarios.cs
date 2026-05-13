using Outputs.Documents.Domain.Doce;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Templates.Doce;

public sealed class CourtesyLetterPreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new("standard", "Standard courtesy letter", typeof(DoceCourtesyLetter), CourtesyLetter());
    }

    private static DoceCourtesyLetter CourtesyLetter()
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
