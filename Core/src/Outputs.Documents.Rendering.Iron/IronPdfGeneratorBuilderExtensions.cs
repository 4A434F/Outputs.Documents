using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Rendering.Iron;

public static class IronPdfGeneratorBuilderExtensions
{
    public static RazorDocumentRenderingBuilder WithIronPdfGenerator(
        this RazorDocumentRenderingBuilder builder,
        Action<IronPdfGeneratorOptions>? configure = null)
    {
        if (configure is not null)
        {
            builder.Services.Configure(configure);
        }

        return builder.WithPdfGenerator<IronPdfGenerator>();
    }
}
