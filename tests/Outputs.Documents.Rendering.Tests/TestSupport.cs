using Microsoft.AspNetCore.Components;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Abstractions.Rendering;
using Outputs.Documents.Domain;

namespace Outputs.Documents.Rendering.Tests;

public sealed class TestDocumentModel : IDocumentModel
{
    public TestHeaderModel? Header { get; init; }

    public TestFooterModel? Footer { get; init; }
}

public sealed class OtherDocumentModel : IDocumentModel
{
}

public sealed class TestHeaderModel
{
    public string Text { get; init; } = string.Empty;
}

public sealed class TestFooterModel
{
    public string Text { get; init; } = string.Empty;
}

[DocumentTemplate(isDefault: true)]
public sealed class DefaultTestTemplate : ComponentBase
{
    [Parameter]
    public TestDocumentModel Model { get; set; } = default!;
}

[DocumentTemplate]
public sealed class AlternateTestTemplate : ComponentBase
{
    [Parameter]
    public TestDocumentModel Model { get; set; } = default!;
}

[DocumentTemplate(isDefault: true)]
public sealed class OtherModelTemplate : ComponentBase
{
    [Parameter]
    public OtherDocumentModel Model { get; set; } = default!;
}

[DocumentTemplate]
[DocumentLayout(
    headerTemplate: typeof(TestHeaderComponent),
    footerTemplate: typeof(TestFooterComponent),
    headerPropertyName: nameof(TestDocumentModel.Header),
    footerPropertyName: nameof(TestDocumentModel.Footer),
    widthCm: 21,
    heightCm: 29.7)]
public sealed class LayoutTestTemplate : ComponentBase
{
    [Parameter]
    public TestDocumentModel Model { get; set; } = default!;
}

public sealed class TestHeaderComponent : ComponentBase
{
    [Parameter]
    public TestHeaderModel Model { get; set; } = default!;
}

public sealed class TestFooterComponent : ComponentBase
{
    [Parameter]
    public TestFooterModel Model { get; set; } = default!;
}

[DocumentTemplate]
public sealed class MissingModelParameterTemplate : ComponentBase
{
}

[DocumentTemplate]
public sealed class NotMarkedParameterTemplate : ComponentBase
{
    public TestDocumentModel Model { get; set; } = default!;
}

[DocumentTemplate]
public sealed class ObjectModelTemplate : ComponentBase
{
    [Parameter]
    public object Model { get; set; } = default!;
}

internal static class TestDescriptors
{
    public static DocumentTemplateDescriptor Create<TModel, TTemplate>(
        bool isDefault = false,
        Type? headerTemplateType = null,
        Type? footerTemplateType = null,
        string? headerPropertyName = null,
        string? footerPropertyName = null,
        double? widthCm = null,
        double? heightCm = null,
        string modelParameterName = "Model")
    {
        return new DocumentTemplateDescriptor(
            typeof(TModel),
            typeof(TTemplate),
            isDefault,
            headerTemplateType,
            footerTemplateType,
            headerPropertyName,
            footerPropertyName,
            widthCm,
            heightCm,
            modelParameterName);
    }
}

internal sealed class NullRule : IDocumentTemplateSelectionRule<TestDocumentModel>
{
    public Type? SelectTemplate(TestDocumentModel model, RenderSource source) => null;
}

internal sealed class SelectDefaultRule : IDocumentTemplateSelectionRule<TestDocumentModel>
{
    public Type? SelectTemplate(TestDocumentModel model, RenderSource source) => typeof(DefaultTestTemplate);
}

internal sealed class SelectAlternateRule : IDocumentTemplateSelectionRule<TestDocumentModel>
{
    public Type? SelectTemplate(TestDocumentModel model, RenderSource source) => typeof(AlternateTestTemplate);
}

internal sealed class AlsoSelectAlternateRule : IDocumentTemplateSelectionRule<TestDocumentModel>
{
    public Type? SelectTemplate(TestDocumentModel model, RenderSource source) => typeof(AlternateTestTemplate);
}

internal sealed class SelectUnregisteredRule : IDocumentTemplateSelectionRule<TestDocumentModel>
{
    public Type? SelectTemplate(TestDocumentModel model, RenderSource source) => typeof(UnregisteredTemplate);
}

internal sealed class SelectOtherModelTemplateRule : IDocumentTemplateSelectionRule<TestDocumentModel>
{
    public Type? SelectTemplate(TestDocumentModel model, RenderSource source) => typeof(OtherModelTemplate);
}

public sealed class UnregisteredTemplate : ComponentBase
{
}

internal sealed class RecordingRazorComponentRenderer : IRazorComponentRenderer
{
    public List<RenderCall> Calls { get; } = [];

    public Task<string> RenderAsync(
        Type componentType,
        IReadOnlyDictionary<string, object?>? parameters = null,
        CancellationToken cancellationToken = default)
    {
        var parameter = parameters?.SingleOrDefault();
        Calls.Add(new RenderCall(componentType, parameter?.Value, parameter?.Key ?? string.Empty));
        return Task.FromResult($"html:{componentType.Name}");
    }

    public Task<string> RenderAsync<TComponent>(
        IReadOnlyDictionary<string, object?>? parameters = null,
        CancellationToken cancellationToken = default)
        where TComponent : IComponent
    {
        return RenderAsync(typeof(TComponent), parameters, cancellationToken);
    }

    public Task<string> RenderAsync<TComponent>(
        object model,
        string parameterName = "Model",
        CancellationToken cancellationToken = default)
        where TComponent : IComponent
    {
        return RenderAsync(typeof(TComponent), model, parameterName, cancellationToken);
    }

    public Task<string> RenderAsync(
        Type componentType,
        object model,
        string parameterName = "Model",
        CancellationToken cancellationToken = default)
    {
        Calls.Add(new RenderCall(componentType, model, parameterName));
        return Task.FromResult($"html:{componentType.Name}");
    }
}

internal sealed record RenderCall(Type ComponentType, object? Model, string ParameterName);

internal sealed class RecordingPdfGenerator : IPdfGenerator
{
    public PdfCall? LastCall { get; private set; }

    public Task<byte[]> GenerateAsync(
        string bodyHtml,
        string? headerHtml = null,
        string? footerHtml = null,
        double? widthCm = null,
        double? heightCm = null,
        CancellationToken cancellationToken = default)
    {
        LastCall = new PdfCall(bodyHtml, headerHtml, footerHtml, widthCm, heightCm);
        return Task.FromResult(new byte[] { 1, 2, 3 });
    }
}

internal sealed record PdfCall(
    string BodyHtml,
    string? HeaderHtml,
    string? FooterHtml,
    double? WidthCm,
    double? HeightCm);
