using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Components.Calibration;
using Outputs.Documents.Rendering;
using Outputs.Documents.Rendering.Iron;

namespace Outputs.Documents.Components.IntegrationTests;

public sealed class PrinterCalibrationIronPdfTests
{
    [Fact]
    [Trait("Category", "Integration")]
    public async Task PrinterCalibrationPage_RendersAsA4PdfWithIron()
    {
        var licenseKey = GetLicenseKey();
        if (string.IsNullOrWhiteSpace(licenseKey))
        {
            return;
        }

        var services = new ServiceCollection();
        services
            .AddRazorDocumentRendering()
            .WithDocumentsFromAssembly(typeof(PrinterCalibrationPage).Assembly)
            .WithIronPdfGenerator(options =>
            {
                options.LicenseKey = licenseKey;
                options.MarginTop = 0;
                options.MarginRight = 0;
                options.MarginBottom = 0;
                options.MarginLeft = 0;
            });

        using var provider = services.BuildServiceProvider();
        var renderer = provider.GetRequiredService<IDocumentRenderer>();

        var pdf = await renderer.RenderAsync(typeof(PrinterCalibrationPage));

        Assert.Equal((byte)'%', pdf[0]);
        Assert.Equal((byte)'P', pdf[1]);
        Assert.Equal((byte)'D', pdf[2]);
        Assert.Equal((byte)'F', pdf[3]);
        Assert.True(pdf.Length > 10_000);

        var outputPath = Path.Combine(
            AppContext.BaseDirectory,
            "TestResults",
            "print-calibration-a4.pdf");

        Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
        await File.WriteAllBytesAsync(outputPath, pdf);
    }

    private static string? GetLicenseKey()
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<PrinterCalibrationIronPdfTests>(optional: true)
            .AddEnvironmentVariables()
            .Build();

        return configuration["IronPdf:LicenseKey"] ?? configuration["IRONPDF_LICENSE_KEY"];
    }
}
