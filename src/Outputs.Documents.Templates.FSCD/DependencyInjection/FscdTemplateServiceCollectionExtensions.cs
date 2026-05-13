using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Templates.FSCD;

public static class FscdTemplateServiceCollectionExtensions
{
    public static RazorDocumentRenderingBuilder WithFscdTemplates(this RazorDocumentRenderingBuilder builder)
    {
        return builder.WithDocumentsFromAssembly(typeof(FscdDocumentTemplate).Assembly);
    }

    public static IServiceCollection AddFscdTemplates(this IServiceCollection services)
    {
        services.AddDocumentTemplatesFromAssembly(typeof(FscdDocumentTemplate).Assembly);
        services.AddDocumentTemplateSelectionRulesFromAssembly(typeof(FscdDocumentTemplate).Assembly);
        return services;
    }
}
