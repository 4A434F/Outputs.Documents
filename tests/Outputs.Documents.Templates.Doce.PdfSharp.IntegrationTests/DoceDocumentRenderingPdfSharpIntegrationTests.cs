using Outputs.Documents.Templates.Doce.PdfSharp.IntegrationTests.Fixture;
using Outputs.Documents.Templates.Doce.PdfSharp.IntegrationTests.Support;

namespace Outputs.Documents.Templates.Doce.PdfSharp.IntegrationTests;

public sealed class DoceDocumentRenderingPdfSharpIntegrationTests(DocumentRendererFixture fixture)
    : IClassFixture<DocumentRendererFixture>
{
    [Fact]
    public async Task RenderCoverPageShortAsync()
    {
        var pdfBytes = await fixture.Renderer.RenderAsync(DoceDocumentSamples.CoverPageShort());

        AssertPdf(pdfBytes);
        await PdfOutput.SaveAsync(pdfBytes, "CoverPageShort.pdf");
    }

    [Fact]
    public async Task RenderCoverPageFullAsync()
    {
        var pdfBytes = await fixture.Renderer.RenderAsync(DoceDocumentSamples.CoverPageFull());

        AssertPdf(pdfBytes);
        await PdfOutput.SaveAsync(pdfBytes, "CoverPageFull.pdf");
    }

    [Fact]
    public async Task RenderDispatchSheetTemplateAsync()
    {
        var pdfBytes = await fixture.Renderer.RenderAsync(DoceDocumentSamples.DispatchSheet());

        AssertPdf(pdfBytes);
        await PdfOutput.SaveAsync(pdfBytes, "DispatchSheet.pdf");
    }

    [Fact]
    public async Task RenderDividerTemplateAsync()
    {
        var pdfBytes = await fixture.Renderer.RenderAsync(DoceDocumentSamples.Divider());

        AssertPdf(pdfBytes);
        await PdfOutput.SaveAsync(pdfBytes, "Divider.pdf");
    }

    [Fact]
    public async Task RenderDeliveryNoteTemplateAsync()
    {
        var pdfBytes = await fixture.Renderer.RenderAsync(DoceDocumentSamples.DeliveryNote());

        AssertPdf(pdfBytes);
        await PdfOutput.SaveAsync(pdfBytes, "DeliveryNote.pdf");
    }

    [Fact]
    public async Task RenderCourtesyLetterTemplateAsync()
    {
        var pdfBytes = await fixture.Renderer.RenderAsync(DoceDocumentSamples.CourtesyLetter());

        AssertPdf(pdfBytes);
        await PdfOutput.SaveAsync(pdfBytes, "CourtesyLetter.pdf");
    }

    [Fact]
    public async Task RenderRegTicketPageTemplateAsync()
    {
        var pdfBytes = await fixture.Renderer.RenderAsync(DoceDocumentSamples.RegTicketPage());

        AssertPdf(pdfBytes);
        await PdfOutput.SaveAsync(pdfBytes, "RegTicketPage.pdf");
    }

    private static void AssertPdf(byte[] pdfBytes)
    {
        Assert.NotNull(pdfBytes);
        Assert.NotEmpty(pdfBytes);
        Assert.StartsWith("%PDF", System.Text.Encoding.ASCII.GetString(pdfBytes, 0, 4));
    }
}
