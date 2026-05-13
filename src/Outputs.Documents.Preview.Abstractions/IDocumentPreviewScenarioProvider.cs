namespace Outputs.Documents.Preview.Abstractions;

public interface IDocumentPreviewScenarioProvider
{
    IEnumerable<DocumentPreviewScenario> GetScenarios();
}
