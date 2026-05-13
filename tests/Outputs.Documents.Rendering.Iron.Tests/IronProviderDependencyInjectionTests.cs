using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering.Iron;

namespace Outputs.Documents.Rendering.Iron.Tests;

public sealed class IronProviderDependencyInjectionTests
{
    [Fact]
    public void WithIronPdfGenerator_RegistersIronPdfGeneratorAndDocumentRenderer()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithIronPdfGenerator(options =>
            {
                options.PaperSize = "Letter";
                options.EnableJavaScript = true;
            });

        using var provider = services.BuildServiceProvider();
        Assert.IsType<IronPdfGenerator>(provider.GetRequiredService<IPdfGenerator>());
        Assert.IsType<DocumentRenderer>(provider.GetRequiredService<IDocumentRenderer>());
    }
}
