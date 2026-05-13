using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Rendering.PdfSharp;

public static class PdfSharpPdfGeneratorBuilderExtensions
{
    public static RazorDocumentRenderingBuilder WithPdfSharpPdfGenerator(
        this RazorDocumentRenderingBuilder builder,
        Action<PdfSharpPdfGeneratorOptions>? configure = null)
    {
        if (configure is not null)
        {
            builder.Services.Configure(configure);
        }

        return builder.WithPdfGenerator<PdfSharpPdfGenerator>();
    }
}
