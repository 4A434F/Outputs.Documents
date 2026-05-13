using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Templates.Doce;
using Outputs.Documents.Domain.Doce;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Templates.Doce.Tests;

public sealed class DoceTemplateRegistrationTests
{
    [Fact]
    public void WithDocumentsFromAssembly_RegistersMigratedDocumentTemplates()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly);

        using var provider = services.BuildServiceProvider();
        var registry = provider.GetRequiredService<IDocumentTemplateRegistry>();

        Assert.Equal(typeof(CTTDispatchSheetTemplate), registry.GetDefault(typeof(CttDispatchSheet)).BodyTemplateType);
        Assert.Equal(typeof(CoverPageTemplate), registry.GetDefault(typeof(CoverPage)).BodyTemplateType);
        Assert.Equal(typeof(DividerTemplate), registry.GetDefault(typeof(Divider)).BodyTemplateType);
        Assert.Equal(typeof(DeliveryNoteTemplate), registry.GetDefault(typeof(DeliveryNote)).BodyTemplateType);
        Assert.Equal(typeof(RegTicketPageTemplate), registry.GetDefault(typeof(RegTicketPage)).BodyTemplateType);
        Assert.Equal(typeof(CourtesyLetterTemplate), registry.GetDefault(typeof(DoceCourtesyLetter)).BodyTemplateType);
    }

    [Fact]
    public void WithDocumentsFromAssembly_RegistersLayoutMetadataForLetterTemplates()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly);

        using var provider = services.BuildServiceProvider();
        var registry = provider.GetRequiredService<IDocumentTemplateRegistry>();
        var descriptor = registry.GetDefault(typeof(DeliveryNote));

        Assert.Equal("Header", descriptor.HeaderPropertyName);
        Assert.Equal("Footer", descriptor.FooterPropertyName);
        Assert.NotNull(descriptor.HeaderTemplateType);
        Assert.NotNull(descriptor.FooterTemplateType);
    }

    [Fact]
    public void WithDocumentsFromAssembly_RegistersCustomSizeForRegTicketPage()
    {
        var services = new ServiceCollection();

        services
            .AddRazorDocumentRendering()
            .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly);

        using var provider = services.BuildServiceProvider();
        var registry = provider.GetRequiredService<IDocumentTemplateRegistry>();
        var descriptor = registry.GetDefault(typeof(RegTicketPage));

        Assert.Equal(23, descriptor.WidthCm);
        Assert.Equal(43, descriptor.HeightCm);
    }
}
