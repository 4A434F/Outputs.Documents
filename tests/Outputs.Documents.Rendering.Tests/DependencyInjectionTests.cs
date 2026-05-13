using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Abstractions.Rendering;
using Outputs.Documents.Rendering.Razor;
using Outputs.Documents.Templates.FSCD;

namespace Outputs.Documents.Rendering.Tests;

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

    [Fact]
    public void WithDocumentsFromAssembly_RegistersTemplateDescriptorsAndSelectionRules()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithDocumentsFromAssembly(typeof(FscdDocumentTemplate).Assembly);

        using var provider = services.BuildServiceProvider();
        var registry = provider.GetRequiredService<IDocumentTemplateRegistry>();
        var rules = provider.GetServices<IDocumentTemplateSelectionRule>().ToArray();

        Assert.Equal(typeof(FscdDocumentTemplate), registry.GetDefault(typeof(FscdDocumentModel)).BodyTemplateType);
        Assert.Contains(rules, rule => rule.GetType() == typeof(FscdDummyTemplateRule));
        Assert.Contains(rules, rule => rule.GetType() == typeof(CourtesyLetterPreviewTemplateRule));
    }

    [Fact]
    public void WithFscdTemplates_RegistersFscdTemplatesAndRulesOnBuilderChain()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithFscdTemplates();

        using var provider = services.BuildServiceProvider();
        var registry = provider.GetRequiredService<IDocumentTemplateRegistry>();
        var rules = provider.GetServices<IDocumentTemplateSelectionRule>().ToArray();

        Assert.Equal(typeof(FscdDocumentTemplate), registry.GetDefault(typeof(FscdDocumentModel)).BodyTemplateType);
        Assert.Contains(rules, rule => rule.GetType() == typeof(FscdDummyTemplateRule));
    }

    [Fact]
    public void AddFscdTemplates_RegistersFscdTemplatesAndRulesOnServiceCollection()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering();
        services.AddFscdTemplates();

        using var provider = services.BuildServiceProvider();
        var registry = provider.GetRequiredService<IDocumentTemplateRegistry>();
        var rules = provider.GetServices<IDocumentTemplateSelectionRule>().ToArray();

        Assert.Equal(typeof(FscdDocumentTemplate), registry.GetDefault(typeof(FscdDocumentModel)).BodyTemplateType);
        Assert.Contains(rules, rule => rule.GetType() == typeof(FscdDummyTemplateRule));
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
