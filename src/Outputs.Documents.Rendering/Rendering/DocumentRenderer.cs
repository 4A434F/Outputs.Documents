using Outputs.Documents.Abstractions;
using Outputs.Documents.Abstractions.Rendering;

namespace Outputs.Documents.Rendering;

public sealed class DocumentRenderer(
    IRazorComponentRenderer components,
    IDocumentTemplateSelector templates,
    IPdfGenerator pdfs)
    : IDocumentRenderer
{
    public Task<byte[]> RenderAsync<TModel>(
        TModel model,
        CancellationToken cancellationToken = default)
        where TModel : IDocumentModel
    {
        return RenderAsync(model, RenderSource.Empty, cancellationToken);
    }

    public async Task<byte[]> RenderAsync<TModel>(
        TModel model,
        RenderSource source,
        CancellationToken cancellationToken = default)
        where TModel : IDocumentModel
    {
        ArgumentNullException.ThrowIfNull(model);
        source ??= RenderSource.Empty;

        var descriptor = templates.Select(model, source);

        var bodyHtml = await components.RenderAsync(
            descriptor.BodyTemplateType,
            model,
            descriptor.ModelParameterName,
            cancellationToken);

        var headerHtml = await RenderPartialAsync(
            descriptor.HeaderTemplateType,
            ResolvePartialModel(model, descriptor.HeaderPropertyName, descriptor.HeaderPropertyAccessor),
            descriptor.ModelParameterName,
            cancellationToken);

        var footerHtml = await RenderPartialAsync(
            descriptor.FooterTemplateType,
            ResolvePartialModel(model, descriptor.FooterPropertyName, descriptor.FooterPropertyAccessor),
            descriptor.ModelParameterName,
            cancellationToken);

        return await pdfs.GenerateAsync(
            bodyHtml,
            headerHtml,
            footerHtml,
            descriptor.WidthCm,
            descriptor.HeightCm,
            cancellationToken);
    }

    private async Task<string?> RenderPartialAsync(
        Type? componentType,
        object? model,
        string parameterName,
        CancellationToken cancellationToken)
    {
        if (componentType is null || model is null)
        {
            return null;
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

        if (accessor is null)
        {
            throw new InvalidOperationException(
                $"No precomputed accessor is available for document layout property '{propertyName}'.");
        }

        return accessor(rootModel);
    }
}
