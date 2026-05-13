using Outputs.Documents.Abstractions;
using Outputs.Documents.Abstractions.Rendering;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Preview;

public sealed class DocumentPreviewHtmlRenderer(IRazorComponentRenderer components)
    : IDocumentPreviewHtmlRenderer
{
    public async Task<string> RenderHtmlAsync(
        DocumentTemplateDescriptor template,
        DocumentPreviewScenario scenario,
        CancellationToken cancellationToken = default)
    {
        var bodyHtml = await components.RenderAsync(
            template.BodyTemplateType,
            scenario.Model,
            template.ModelParameterName,
            cancellationToken);

        var headerHtml = await RenderPartialAsync(
            template.HeaderTemplateType,
            ResolvePartialModel(scenario.Model, template.HeaderPropertyName, template.HeaderPropertyAccessor),
            template.ModelParameterName,
            cancellationToken);

        var footerHtml = await RenderPartialAsync(
            template.FooterTemplateType,
            ResolvePartialModel(scenario.Model, template.FooterPropertyName, template.FooterPropertyAccessor),
            template.ModelParameterName,
            cancellationToken);

        return string.Concat(
            "<!doctype html><html><head><meta charset=\"utf-8\" />",
            "<style>body{margin:0;background:#f3f4f6;color:#111827;font-family:Arial,sans-serif;}",
            ".document-preview-shell{background:white;min-height:100vh;}</style>",
            "</head><body><div class=\"document-preview-shell\">",
            headerHtml,
            bodyHtml,
            footerHtml,
            "</div></body></html>");
    }

    private async Task<string> RenderPartialAsync(
        Type? componentType,
        object? model,
        string parameterName,
        CancellationToken cancellationToken)
    {
        if (componentType is null || model is null)
        {
            return string.Empty;
        }

        return await components.RenderAsync(componentType, model, parameterName, cancellationToken);
    }

    private static object? ResolvePartialModel(
        object rootModel,
        string? propertyName,
        Func<object, object?>? accessor)
    {
        if (string.IsNullOrWhiteSpace(propertyName))
        {
            return rootModel;
        }

        return accessor?.Invoke(rootModel);
    }
}
