using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering;
using Outputs.Documents.Rendering.PdfSharp;
using Outputs.Documents.Templates.Doce;

namespace Outputs.Documents.Templates.Doce.PdfSharp.IntegrationTests.Fixture;

public sealed class DocumentRendererFixture : IAsyncDisposable
{
    private readonly ServiceProvider _provider;
    private readonly AsyncServiceScope _scope;

    public IDocumentRenderer Renderer { get; }

    public DocumentRendererFixture()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
            .WithPdfSharpPdfGenerator();

        var doceProjectRoot = FindProjectRoot("src", "Outputs.Documents.Templates.Doce");
        var wwwroot = Path.Combine(doceProjectRoot, "wwwroot");

        services.Configure<StaticFilePaths>(options =>
        {
            options.Path = wwwroot;
            options.Logos = Path.Combine(wwwroot, "Logos");
            options.Fonts = Path.Combine(wwwroot, "fonts");
        });

        _provider = services.BuildServiceProvider(validateScopes: true);
        _scope = _provider.CreateAsyncScope();
        Renderer = _scope.ServiceProvider.GetRequiredService<IDocumentRenderer>();
    }

    public async ValueTask DisposeAsync()
    {
        await _scope.DisposeAsync();
        await _provider.DisposeAsync();
    }

    private static string FindProjectRoot(params string[] segments)
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);

        while (directory is not null)
        {
            var candidate = Path.Combine(new[] { directory.FullName }.Concat(segments).ToArray());

            if (Directory.Exists(candidate))
            {
                return candidate;
            }

            directory = directory.Parent;
        }

        throw new DirectoryNotFoundException(
            $"Could not find project directory '{Path.Combine(segments)}' from '{AppContext.BaseDirectory}'.");
    }
}
