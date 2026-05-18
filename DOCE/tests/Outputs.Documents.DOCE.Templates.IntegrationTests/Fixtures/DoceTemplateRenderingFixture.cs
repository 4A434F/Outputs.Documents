using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Abstractions.Rendering;
using Outputs.Documents.Components;
using Outputs.Documents.Rendering;
using Outputs.Documents.Rendering.Iron;

namespace Outputs.Documents.DOCE.Templates.IntegrationTests.Fixtures;

public sealed class DoceTemplateRenderingFixture : IDisposable
{
    private readonly ServiceProvider? _provider;

    public DoceTemplateRenderingFixture()
    {
        LicenseKey = GetLicenseKey();
        if (string.IsNullOrWhiteSpace(LicenseKey))
        {
            return;
        }

        var services = new ServiceCollection();
        services.AddOptions<StaticFilePaths>();
        services.Configure<IronPdfGeneratorOptions>(options =>
        {
            options.LicenseKey = LicenseKey;
            options.MarginTop = 0;
            options.MarginRight = 0;
            options.MarginBottom = 0;
            options.MarginLeft = 0;
        });
        services.AddRazorComponentRendering();
        services.AddScoped<IPdfGenerator, IronPdfGenerator>();

        _provider = services.BuildServiceProvider();
    }

    public string? LicenseKey { get; }

    public bool CanRender => _provider is not null;

    public async Task<byte[]> RenderTemplateAsync<TTemplate, TModel>(
        TModel model,
        string outputFileName,
        CancellationToken cancellationToken = default)
        where TTemplate : IComponent
        where TModel : IDocumentModel
    {
        if (_provider is null)
        {
            throw new InvalidOperationException("IronPDF license key was not configured.");
        }

        var components = _provider.GetRequiredService<IRazorComponentRenderer>();
        var pdfs = _provider.GetRequiredService<IPdfGenerator>();
        var descriptor = DocumentScanner.CreateDescriptor(typeof(TTemplate))
            ?? throw new InvalidOperationException(
                $"Template '{typeof(TTemplate).FullName}' is missing {nameof(DocumentTemplateAttribute)}.");

        var html = await components.RenderAsync(
            descriptor.BodyTemplateType,
            model,
            descriptor.ModelParameterName,
            cancellationToken);

        var headerHtml = await RenderPartialAsync(
            components,
            descriptor.HeaderTemplateType,
            ResolvePartialModel(model, descriptor.HeaderPropertyName, descriptor.HeaderPropertyAccessor),
            descriptor.ModelParameterName,
            cancellationToken);

        var footerHtml = await RenderPartialAsync(
            components,
            descriptor.FooterTemplateType,
            ResolvePartialModel(model, descriptor.FooterPropertyName, descriptor.FooterPropertyAccessor),
            descriptor.ModelParameterName,
            cancellationToken);

        var pdf = await pdfs.GenerateAsync(
            html,
            headerHtml,
            footerHtml,
            descriptor.WidthCm,
            descriptor.HeightCm,
            cancellationToken);

        AssertPdf(pdf);
        await WriteOutputAsync(outputFileName, pdf, cancellationToken);

        return pdf;
    }

    public void Dispose()
    {
        _provider?.Dispose();
    }

    private static async Task<string?> RenderPartialAsync(
        IRazorComponentRenderer components,
        Type? componentType,
        object? model,
        string parameterName,
        CancellationToken cancellationToken)
    {
        if (componentType is null || model is null)
        {
            return null;
        }

        return await components.RenderAsync(componentType, model, parameterName, cancellationToken);
    }

    private static object? ResolvePartialModel(
        object rootModel,
        string? propertyName,
        Func<object, object?>? accessor)
    {
        if (string.IsNullOrWhiteSpace(propertyName))
        {
            return rootModel;
        }

        if (accessor is null)
        {
            throw new InvalidOperationException(
                $"No precomputed accessor is available for document layout property '{propertyName}'.");
        }

        return accessor(rootModel);
    }

    private static async Task WriteOutputAsync(
        string outputFileName,
        byte[] pdf,
        CancellationToken cancellationToken)
    {
        var outputPath = Path.Combine(
            AppContext.BaseDirectory,
            "TestResults",
            outputFileName);

        Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
        await File.WriteAllBytesAsync(outputPath, pdf, cancellationToken);
    }

    private static void AssertPdf(byte[] pdf)
    {
        Assert.Equal((byte)'%', pdf[0]);
        Assert.Equal((byte)'P', pdf[1]);
        Assert.Equal((byte)'D', pdf[2]);
        Assert.Equal((byte)'F', pdf[3]);
        Assert.True(pdf.Length > 1_000);
    }

    private static string? GetLicenseKey()
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<DoceTemplateRenderingFixture>(optional: true)
            .AddEnvironmentVariables()
            .Build();

        return configuration["IronPdf:LicenseKey"] ?? configuration["IRONPDF_LICENSE_KEY"];
    }
}
