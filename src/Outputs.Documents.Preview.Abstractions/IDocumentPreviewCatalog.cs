using Outputs.Documents.Abstractions;

namespace Outputs.Documents.Preview.Abstractions;

public interface IDocumentPreviewCatalog
{
    IReadOnlyList<DocumentTemplateDescriptor> Templates { get; }

    IReadOnlyList<DocumentPreviewScenario> Scenarios { get; }

    DocumentTemplateDescriptor? FindTemplate(string templateKey);

    IReadOnlyList<DocumentPreviewScenario> GetScenariosForTemplate(
        DocumentTemplateDescriptor template);

    DocumentPreviewScenario? FindScenario(
        DocumentTemplateDescriptor template,
        string? scenarioKey);
}
