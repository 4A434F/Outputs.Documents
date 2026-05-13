using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering.Iron;

namespace Outputs.Documents.Rendering.Iron.Tests;

public sealed class IronProviderDependencyInjectionTests
{
    [Fact]
    public void WithIronPdfGenerator_RegistersIronPdfGeneratorAndDocumentRenderer()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithIronPdfGenerator(options =>
            {
                options.PaperSize = "Letter";
                options.EnableJavaScript = true;
            });

        using var provider = services.BuildServiceProvider();
        Assert.IsType<IronPdfGenerator>(provider.GetRequiredService<IPdfGenerator>());
        Assert.IsType<DocumentRenderer>(provider.GetRequiredService<IDocumentRenderer>());
    }

    [Fact]
    public async Task IronPdfGenerator_GeneratesPdfBytesFromHtml_WhenLicenseKeyIsConfigured()
    {
        var licenseKey = GetLicenseKey();
        if (string.IsNullOrWhiteSpace(licenseKey))
        {
            return;
        }

        var services = new ServiceCollection();
        services
            .AddRazorDocumentRendering()
            .WithIronPdfGenerator(options => options.LicenseKey = licenseKey);

        using var provider = services.BuildServiceProvider();
        var generator = provider.GetRequiredService<IPdfGenerator>();

        var pdf = await generator.GenerateAsync("<h1>Hello IronPDF</h1>");

        Assert.True(pdf.Length > 0);
        Assert.Equal((byte)'%', pdf[0]);
        Assert.Equal((byte)'P', pdf[1]);
        Assert.Equal((byte)'D', pdf[2]);
        Assert.Equal((byte)'F', pdf[3]);
    }

    private static string? GetLicenseKey()
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<IronProviderDependencyInjectionTests>(optional: true)
            .AddEnvironmentVariables()
            .Build();

        return configuration["IronPdf:LicenseKey"] ?? configuration["IRONPDF_LICENSE_KEY"];
    }
}
