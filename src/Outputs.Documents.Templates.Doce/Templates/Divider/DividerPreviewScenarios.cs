using Outputs.Documents.Domain.Doce;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Templates.Doce;

public sealed class DividerPreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new("urgent", "Urgent divider", typeof(Divider), new Divider("Urgente"));
    }
}
