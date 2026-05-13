using Outputs.Documents.Domain.Doce;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Templates.Doce;

public sealed class CTTDispatchSheetPreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new("dispatch-standard", "Dispatch with many rows", typeof(CttDispatchSheet), DispatchSheet());
    }

    private static CttDispatchSheet DispatchSheet()
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

    private static DocumentTraceId Trace()
    {
        return new DocumentTraceId
        {
            Line1 = "X004 07/11/2025 06:36:13",
            Line2 = "0000000004 1002 PGOC015A"
        };
    }
}
