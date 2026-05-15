using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Outputs.Documents.Abstractions;

namespace Outputs.Documents.Samples;

public static class DocumentModelSampleServiceCollectionExtensions
{
    public static RazorDocumentRenderingBuilder WithSamplesFromAssembly(
        this RazorDocumentRenderingBuilder builder,
        Assembly assembly)
    {
        var descriptors = DocumentModelSampleScanner.ScanSamples(assembly);
        var catalog = new DocumentModelSampleCatalog(assembly.GetName().Name ?? assembly.FullName ?? assembly.ToString(), descriptors);

        builder.Services.AddSingleton(catalog);
        builder.Services.TryAddSingleton<IDocumentModelSampleCatalog, DocumentModelSampleCatalogCollection>();

        return builder;
    }
}
