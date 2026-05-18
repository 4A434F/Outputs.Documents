using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Abstractions.Rendering;
using Outputs.Documents.Rendering.Razor;

namespace Outputs.Documents.Rendering;

public static class RenderingServiceCollectionExtensions
{
    public static IServiceCollection AddRazorComponentRendering(this IServiceCollection services)
    {
        services.AddLogging();
        services.TryAddScoped<HtmlRenderer>();
        services.TryAddScoped<IRazorComponentRenderer, RazorComponentHtmlRenderer>();

        return services;
    }
    
    public static RazorDocumentRenderingBuilder AddRazorDocumentRendering(this IServiceCollection services)
    {
        services.AddRazorComponentRendering();
        services.TryAddSingleton<IDocumentTemplateRegistry, DocumentTemplateCatalog>();
        services.TryAddScoped<IDocumentTemplateSelector, DocumentTemplateSelector>();

        return new RazorDocumentRenderingBuilder(services);
    }

    public static IServiceCollection AddDocumentRendering(this IServiceCollection services)
    {
        services.AddRazorDocumentRendering();
        return services;
    }

    public static RazorDocumentRenderingBuilder WithPdfGenerator<TPdfGenerator>(
        this RazorDocumentRenderingBuilder builder)
        where TPdfGenerator : class, IPdfGenerator
    {
        builder.Services.TryAddScoped<IPdfGenerator, TPdfGenerator>();
        builder.Services.TryAddScoped<IDocumentRenderer, DocumentRenderer>();
        return builder;
    }

    public static RazorDocumentRenderingBuilder WithPdfGenerator(
        this RazorDocumentRenderingBuilder builder,
        Func<IServiceProvider, IPdfGenerator> factory)
    {
        builder.Services.TryAddScoped(factory);
        builder.Services.TryAddScoped<IDocumentRenderer, DocumentRenderer>();
        return builder;
    }

    public static RazorDocumentRenderingBuilder WithPdfGenerator(
        this RazorDocumentRenderingBuilder builder,
        IPdfGenerator generator)
    {
        builder.Services.TryAddSingleton(generator);
        builder.Services.TryAddScoped<IDocumentRenderer, DocumentRenderer>();
        return builder;
    }

    public static RazorDocumentRenderingBuilder WithDocumentsFromAssembly(
        this RazorDocumentRenderingBuilder builder,
        Assembly assembly)
    {
        builder.Services.AddDocumentTemplatesFromAssembly(assembly);
        builder.Services.AddDocumentTemplateSelectionRulesFromAssembly(assembly);
        return builder;
    }
    public static IServiceCollection AddDocumentTemplatesFromAssembly(
        this IServiceCollection services,
        Assembly assembly)
    {
        foreach (var descriptor in DocumentScanner.ScanTemplates(assembly))
        {
            services.AddSingleton(descriptor);
        }

        return services;
    }

    public static IServiceCollection AddDocumentTemplateSelectionRulesFromAssembly(
        this IServiceCollection services,
        Assembly assembly)
    {
        foreach (var ruleType in DocumentScanner.ScanSelectionRules(assembly))
        {
            services.AddTransient(typeof(IDocumentTemplateSelectionRule), ruleType);
        }

        return services;
    }
}
