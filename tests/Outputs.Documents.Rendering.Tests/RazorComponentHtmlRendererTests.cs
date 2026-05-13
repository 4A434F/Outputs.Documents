using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Rendering.Razor;

namespace Outputs.Documents.Rendering.Tests;

public sealed class RazorComponentHtmlRendererTests
{
    [Fact]
    public async Task RenderAsync_RendersComponentWithDictionaryParameters()
    {
        var renderer = CreateRenderer();

        var html = await renderer.RenderAsync(
            typeof(GreetingComponent),
            new Dictionary<string, object?>
            {
                [nameof(GreetingComponent.Name)] = "Ada"
            });

        Assert.Contains("Hello Ada", html);
    }

    [Fact]
    public async Task RenderAsync_Generic_RendersComponentWithDictionaryParameters()
    {
        var renderer = CreateRenderer();

        var html = await renderer.RenderAsync<GreetingComponent>(
            new Dictionary<string, object?>
            {
                [nameof(GreetingComponent.Name)] = "Grace"
            });

        Assert.Contains("Hello Grace", html);
    }

    [Fact]
    public async Task RenderAsync_ModelOverload_RendersModelUsingParameterName()
    {
        var renderer = CreateRenderer();
        var model = new TestDocumentModel();

        var html = await renderer.RenderAsync(typeof(ModelEchoComponent), model);

        Assert.Contains(nameof(TestDocumentModel), html);
    }

    [Fact]
    public async Task RenderAsync_GenericModelOverload_RendersModelUsingParameterName()
    {
        var renderer = CreateRenderer();
        var model = new TestDocumentModel();

        var html = await renderer.RenderAsync<ModelEchoComponent>(model);

        Assert.Contains(nameof(TestDocumentModel), html);
    }

    [Fact]
    public async Task RenderAsync_CustomModelParameterName_RendersModelUsingThatParameter()
    {
        var renderer = CreateRenderer();
        var model = new TestDocumentModel();

        var html = await renderer.RenderAsync(typeof(CustomParameterModelEchoComponent), model, "Document");

        Assert.Contains(nameof(TestDocumentModel), html);
    }

    [Fact]
    public async Task RenderAsync_NullParameters_RendersComponentWithoutParameters()
    {
        var renderer = CreateRenderer();

        var html = await renderer.RenderAsync(typeof(StaticComponent));

        Assert.Contains("Static content", html);
    }

    [Fact]
    public async Task RenderAsync_ThrowsWhenComponentTypeIsNull()
    {
        var renderer = CreateRenderer();

        await Assert.ThrowsAsync<ArgumentNullException>(() =>
            renderer.RenderAsync(null!));
    }

    [Fact]
    public async Task RenderAsync_ThrowsWhenComponentTypeDoesNotImplementIComponent()
    {
        var renderer = CreateRenderer();

        var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
            renderer.RenderAsync(typeof(NotAComponent)));

        Assert.Contains(nameof(IComponent), exception.Message);
    }

    [Fact]
    public async Task RenderAsync_ModelOverloadThrowsWhenModelIsNull()
    {
        var renderer = CreateRenderer();
        object model = null!;

        await Assert.ThrowsAsync<ArgumentNullException>(() =>
            renderer.RenderAsync(typeof(ModelEchoComponent), model));
    }

    [Fact]
    public async Task RenderAsync_ThrowsWhenCancellationIsAlreadyRequested()
    {
        var renderer = CreateRenderer();
        using var cancellation = new CancellationTokenSource();
        await cancellation.CancelAsync();

        await Assert.ThrowsAsync<OperationCanceledException>(() =>
            renderer.RenderAsync(typeof(StaticComponent), cancellationToken: cancellation.Token));
    }

    private static RazorComponentHtmlRenderer CreateRenderer()
    {
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddScoped<Microsoft.AspNetCore.Components.Web.HtmlRenderer>();
        return new RazorComponentHtmlRenderer(services.BuildServiceProvider());
    }

    private sealed class NotAComponent
    {
    }
}
