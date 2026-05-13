using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering;
using Outputs.Documents.Rendering.Iron;
using Outputs.Documents.Templates.Doce;

namespace Outputs.Documents.Templates.Doce.Iron.IntegrationTests.Fixture;

public sealed class IronDocumentRendererFixture : IAsyncDisposable
{
    private readonly ServiceProvider? _provider;
    private readonly AsyncServiceScope _scope;

    public IDocumentRenderer? Renderer { get; }

    public bool HasLicenseKey { get; }

    public IronDocumentRendererFixture()
    {
        var licenseKey = GetLicenseKey();
        HasLicenseKey = !string.IsNullOrWhiteSpace(licenseKey);

        if (!HasLicenseKey)
        {
            return;
        }

        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
            .WithIronPdfGenerator(options => options.LicenseKey = licenseKey);

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
        if (_provider is null)
        {
            return;
        }

        await _scope.DisposeAsync();
        await _provider.DisposeAsync();
    }

    private static string? GetLicenseKey()
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<IronDocumentRendererFixture>(optional: true)
            .AddEnvironmentVariables()
            .Build();

        return configuration["IronPdf:LicenseKey"] ?? configuration["IRONPDF_LICENSE_KEY"];
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
