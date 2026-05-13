using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering.PdfSharp;

namespace Outputs.Documents.Rendering.PdfSharp.Tests;

public sealed class PdfSharpProviderDependencyInjectionTests
{
    [Fact]
    public void WithPdfSharpPdfGenerator_RegistersPdfSharpPdfGeneratorAndDocumentRenderer()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithPdfSharpPdfGenerator(options =>
            {
                options.PageSize = "Letter";
                options.MarginTop = 10;
            });

        using var provider = services.BuildServiceProvider();
        Assert.IsType<PdfSharpPdfGenerator>(provider.GetRequiredService<IPdfGenerator>());
        Assert.IsType<DocumentRenderer>(provider.GetRequiredService<IDocumentRenderer>());
    }

    [Fact]
    public async Task PdfSharpPdfGenerator_GeneratesPdfBytesFromHtml()
    {
        var services = new ServiceCollection();
        services
            .AddRazorDocumentRendering()
            .WithPdfSharpPdfGenerator();

        using var provider = services.BuildServiceProvider();
        var generator = provider.GetRequiredService<IPdfGenerator>();

        var pdf = await generator.GenerateAsync("<h1>Hello PDFsharp</h1>");

        Assert.True(pdf.Length > 0);
        Assert.Equal((byte)'%', pdf[0]);
        Assert.Equal((byte)'P', pdf[1]);
        Assert.Equal((byte)'D', pdf[2]);
        Assert.Equal((byte)'F', pdf[3]);
    }
}
