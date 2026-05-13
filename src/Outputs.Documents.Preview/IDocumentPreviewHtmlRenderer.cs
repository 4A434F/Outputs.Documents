using Outputs.Documents.Abstractions;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Preview;

public interface IDocumentPreviewHtmlRenderer
{
    Task<string> RenderHtmlAsync(
        DocumentTemplateDescriptor template,
        DocumentPreviewScenario scenario,
        CancellationToken cancellationToken = default);
}
