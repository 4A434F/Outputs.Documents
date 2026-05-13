using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Preview.Abstractions;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Preview;

public static class DocumentPreviewServiceCollectionExtensions
{
    public static RazorDocumentPreviewBuilder AddRazorDocumentPreview(this IServiceCollection services)
    {
        services.AddRazorComponentRendering();
        services.TryAddSingleton<IDocumentPreviewCatalog, DocumentPreviewCatalog>();
        services.TryAddScoped<IDocumentPreviewHtmlRenderer, DocumentPreviewHtmlRenderer>();

        return new RazorDocumentPreviewBuilder(services);
    }

    public static RazorDocumentPreviewBuilder WithDocumentPreviewAssembly(
        this RazorDocumentPreviewBuilder builder,
        Assembly assembly)
    {
        return builder
            .WithDocumentsFromAssembly(assembly)
            .WithPreviewScenariosFromAssembly(assembly);
    }

    public static RazorDocumentPreviewBuilder WithDocumentsFromAssembly(
        this RazorDocumentPreviewBuilder builder,
        Assembly assembly)
    {
        foreach (var descriptor in DocumentPreviewDiscovery.DiscoverTemplates(assembly))
        {
            builder.Services.AddSingleton(descriptor);
        }

        return builder;
    }

    public static RazorDocumentPreviewBuilder WithPreviewScenariosFromAssembly(
        this RazorDocumentPreviewBuilder builder,
        Assembly assembly)
    {
        foreach (var providerType in DocumentPreviewDiscovery.DiscoverScenarioProviders(assembly))
        {
            builder.Services.AddSingleton(typeof(IDocumentPreviewScenarioProvider), providerType);
        }

        return builder;
    }
}
