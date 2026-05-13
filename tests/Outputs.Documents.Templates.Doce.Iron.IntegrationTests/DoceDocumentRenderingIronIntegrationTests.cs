using Outputs.Documents.Templates.Doce.PdfSharp.IntegrationTests.Support;
using Outputs.Documents.Templates.Doce.Iron.IntegrationTests.Fixture;

namespace Outputs.Documents.Templates.Doce.Iron.IntegrationTests;

public sealed class DoceDocumentRenderingIronIntegrationTests(IronDocumentRendererFixture fixture)
    : IClassFixture<IronDocumentRendererFixture>
{
    [Fact]
    public async Task RenderCoverPageShortAsync()
    {
        await RenderAndSaveAsync(DoceDocumentSamples.CoverPageShort(), "Iron-CoverPageShort.pdf");
    }

    [Fact]
    public async Task RenderCoverPageFullAsync()
    {
        await RenderAndSaveAsync(DoceDocumentSamples.CoverPageFull(), "Iron-CoverPageFull.pdf");
    }

    [Fact]
    public async Task RenderDispatchSheetTemplateAsync()
    {
        await RenderAndSaveAsync(DoceDocumentSamples.DispatchSheet(), "Iron-DispatchSheet.pdf");
    }

    [Fact]
    public async Task RenderDividerTemplateAsync()
    {
        await RenderAndSaveAsync(DoceDocumentSamples.Divider(), "Iron-Divider.pdf");
    }

    [Fact]
    public async Task RenderDeliveryNoteTemplateAsync()
    {
        await RenderAndSaveAsync(DoceDocumentSamples.DeliveryNote(), "Iron-DeliveryNote.pdf");
    }

    [Fact]
    public async Task RenderCourtesyLetterTemplateAsync()
    {
        await RenderAndSaveAsync(DoceDocumentSamples.CourtesyLetter(), "Iron-CourtesyLetter.pdf");
    }

    [Fact]
    public async Task RenderRegTicketPageTemplateAsync()
    {
        await RenderAndSaveAsync(DoceDocumentSamples.RegTicketPage(), "Iron-RegTicketPage.pdf");
    }

    private async Task RenderAndSaveAsync<TModel>(TModel model, string fileName)
        where TModel : Outputs.Documents.Domain.IDocumentModel
    {
        if (!fixture.HasLicenseKey)
        {
            return;
        }

        var pdfBytes = await fixture.Renderer!.RenderAsync(model);

        Assert.NotNull(pdfBytes);
        Assert.NotEmpty(pdfBytes);
        Assert.StartsWith("%PDF", System.Text.Encoding.ASCII.GetString(pdfBytes, 0, 4));
        await PdfOutput.SaveAsync(pdfBytes, fileName);
    }
}
