using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions;
using Outputs.Documents.DOCE.Templates;
using Outputs.Documents.DOCE.Contracts;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.DOCE.Templates.Tests;

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

        Assert.Equal(typeof(CTTDispatchSheetTemplate), registry.GetDefault(typeof(DC003CttDispatchSheet)).BodyTemplateType);
        Assert.Equal(typeof(CoverPageTemplate), registry.GetDefault(typeof(DC000CoverPage)).BodyTemplateType);
        Assert.Equal(typeof(DividerTemplate), registry.GetDefault(typeof(DC002Divider)).BodyTemplateType);
        Assert.Equal(typeof(DeliveryNoteTemplate), registry.GetDefault(typeof(DC004DeliveryNote)).BodyTemplateType);
        Assert.Equal(typeof(RegTicketPageTemplate), registry.GetDefault(typeof(DC005RegTicketPage)).BodyTemplateType);
        Assert.Equal(typeof(CourtesyLetterTemplate), registry.GetDefault(typeof(DC001CourtesyLetter)).BodyTemplateType);
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
        var descriptor = registry.GetDefault(typeof(DC004DeliveryNote));

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
        var descriptor = registry.GetDefault(typeof(DC005RegTicketPage));

        Assert.Equal(23, descriptor.WidthCm);
        Assert.Equal(43, descriptor.HeightCm);
    }
}
