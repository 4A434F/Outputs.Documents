using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Templates.Doce;

public static class DoceTemplateServiceCollectionExtensions
{
    public static RazorDocumentRenderingBuilder WithDoceTemplates(this RazorDocumentRenderingBuilder builder)
    {
        return builder.WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly);
    }

    public static IServiceCollection AddDoceTemplates(this IServiceCollection services)
    {
        services.AddDocumentTemplatesFromAssembly(typeof(CourtesyLetterTemplate).Assembly);
        services.AddDocumentTemplateSelectionRulesFromAssembly(typeof(CourtesyLetterTemplate).Assembly);
        return services;
    }
}
