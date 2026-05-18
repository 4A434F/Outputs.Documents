using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Abstractions.Rendering;
using Outputs.Documents.Rendering.Razor;

namespace Outputs.Documents.Rendering.UnitTests;

public sealed class DependencyInjectionTests
{
    [Fact]
    public void AddRazorDocumentRendering_RegistersBaseRenderingServices()
    {
        var services = new ServiceCollection();

        services.AddRazorDocumentRendering();

        using var provider = services.BuildServiceProvider();
        Assert.IsType<DocumentTemplateCatalog>(provider.GetRequiredService<IDocumentTemplateRegistry>());
        Assert.IsType<DocumentTemplateSelector>(provider.GetRequiredService<IDocumentTemplateSelector>());
        Assert.IsType<RazorComponentHtmlRenderer>(provider.GetRequiredService<IRazorComponentRenderer>());
    }

    [Fact]
    public void AddRazorDocumentRendering_DoesNotRegisterDocumentRendererWithoutPdfGenerator()
    {
        var services = new ServiceCollection();

        services.AddRazorDocumentRendering();

        using var provider = services.BuildServiceProvider();
        Assert.Null(provider.GetService<IDocumentRenderer>());
        Assert.Null(provider.GetService<IPdfGenerator>());
    }

    [Fact]
    public void WithPdfGeneratorType_RegistersPdfGeneratorAndDocumentRenderer()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithPdfGenerator<DummyPdfGenerator>();

        using var provider = services.BuildServiceProvider();
        Assert.IsType<DummyPdfGenerator>(provider.GetRequiredService<IPdfGenerator>());
        Assert.IsType<DocumentRenderer>(provider.GetRequiredService<IDocumentRenderer>());
    }

    [Fact]
    public void WithPdfGeneratorFactory_RegistersPdfGeneratorAndDocumentRenderer()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithPdfGenerator(_ => new DummyPdfGenerator());

        using var provider = services.BuildServiceProvider();
        Assert.IsType<DummyPdfGenerator>(provider.GetRequiredService<IPdfGenerator>());
        Assert.IsType<DocumentRenderer>(provider.GetRequiredService<IDocumentRenderer>());
    }

    [Fact]
    public void WithPdfGeneratorInstance_RegistersPdfGeneratorAndDocumentRenderer()
    {
        var services = new ServiceCollection();
        var generator = new DummyPdfGenerator();

        services
            .AddRazorDocumentRendering()
            .WithPdfGenerator(generator);

        using var provider = services.BuildServiceProvider();
        Assert.Same(generator, provider.GetRequiredService<IPdfGenerator>());
        Assert.IsType<DocumentRenderer>(provider.GetRequiredService<IDocumentRenderer>());
    }
    

    private sealed class DummyPdfGenerator : IPdfGenerator
    {
        public Task<byte[]> GenerateAsync(
            string bodyHtml,
            string? headerHtml = null,
            string? footerHtml = null,
            double? widthCm = null,
            double? heightCm = null,
            CancellationToken cancellationToken = default)
        {
            return Task.FromResult(System.Text.Encoding.UTF8.GetBytes(bodyHtml));
        }
    }
}
