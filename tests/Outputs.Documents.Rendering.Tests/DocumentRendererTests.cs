using Outputs.Documents.Abstractions;
using Outputs.Documents.Abstractions.Rendering;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Rendering.Tests;

public sealed class DocumentRendererTests
{
    [Fact]
    public async Task RenderAsync_PassesRootModelToBodyUsingDescriptorParameterName()
    {
        var model = new TestDocumentModel();
        var descriptor = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(modelParameterName: "Document");
        var components = new RecordingRazorComponentRenderer();
        var pdfs = new RecordingPdfGenerator();
        var renderer = CreateRenderer(descriptor, components, pdfs);

        await renderer.RenderAsync(model, RenderSource.Empty);

        var body = Assert.Single(components.Calls);
        Assert.Equal(typeof(DefaultTestTemplate), body.ComponentType);
        Assert.Same(model, body.Model);
        Assert.Equal("Document", body.ParameterName);
        Assert.Equal("html:DefaultTestTemplate", pdfs.LastCall!.BodyHtml);
    }

    [Fact]
    public async Task RenderAsync_PassesConfiguredHeaderPropertyToHeaderUsingDescriptorParameterName()
    {
        var model = new TestDocumentModel { Header = new TestHeaderModel { Text = "header" } };
        var descriptor = TestDescriptors.Create<TestDocumentModel, LayoutTestTemplate>(
            headerTemplateType: typeof(TestHeaderComponent),
            headerPropertyName: nameof(TestDocumentModel.Header),
            modelParameterName: "Document") with
        {
            HeaderPropertyAccessor = value => ((TestDocumentModel)value).Header
        };
        var components = new RecordingRazorComponentRenderer();
        var renderer = CreateRenderer(descriptor, components, new RecordingPdfGenerator());

        await renderer.RenderAsync(model, RenderSource.Empty);

        Assert.Collection(
            components.Calls,
            call => Assert.Equal(typeof(LayoutTestTemplate), call.ComponentType),
            call =>
            {
                Assert.Equal(typeof(TestHeaderComponent), call.ComponentType);
                Assert.Same(model.Header, call.Model);
                Assert.Equal("Document", call.ParameterName);
            });
    }

    [Fact]
    public async Task RenderAsync_PassesConfiguredFooterPropertyToFooterUsingDescriptorParameterName()
    {
        var model = new TestDocumentModel { Footer = new TestFooterModel { Text = "footer" } };
        var descriptor = TestDescriptors.Create<TestDocumentModel, LayoutTestTemplate>(
            footerTemplateType: typeof(TestFooterComponent),
            footerPropertyName: nameof(TestDocumentModel.Footer),
            modelParameterName: "Document") with
        {
            FooterPropertyAccessor = value => ((TestDocumentModel)value).Footer
        };
        var components = new RecordingRazorComponentRenderer();
        var renderer = CreateRenderer(descriptor, components, new RecordingPdfGenerator());

        await renderer.RenderAsync(model, RenderSource.Empty);

        Assert.Collection(
            components.Calls,
            call => Assert.Equal(typeof(LayoutTestTemplate), call.ComponentType),
            call =>
            {
                Assert.Equal(typeof(TestFooterComponent), call.ComponentType);
                Assert.Same(model.Footer, call.Model);
                Assert.Equal("Document", call.ParameterName);
            });
    }

    [Fact]
    public async Task RenderAsync_SkipsHeaderWhenConfiguredPropertyIsNull()
    {
        var model = new TestDocumentModel { Header = null };
        var descriptor = TestDescriptors.Create<TestDocumentModel, LayoutTestTemplate>(
            headerTemplateType: typeof(TestHeaderComponent),
            headerPropertyName: nameof(TestDocumentModel.Header)) with
        {
            HeaderPropertyAccessor = value => ((TestDocumentModel)value).Header
        };
        var components = new RecordingRazorComponentRenderer();
        var renderer = CreateRenderer(descriptor, components, new RecordingPdfGenerator());

        await renderer.RenderAsync(model, RenderSource.Empty);

        Assert.Single(components.Calls);
    }

    [Fact]
    public async Task RenderAsync_PassesHtmlAndSizeToPdfGenerator()
    {
        var model = new TestDocumentModel
        {
            Header = new TestHeaderModel(),
            Footer = new TestFooterModel()
        };
        var descriptor = TestDescriptors.Create<TestDocumentModel, LayoutTestTemplate>(
            headerTemplateType: typeof(TestHeaderComponent),
            footerTemplateType: typeof(TestFooterComponent),
            headerPropertyName: nameof(TestDocumentModel.Header),
            footerPropertyName: nameof(TestDocumentModel.Footer),
            widthCm: 21,
            heightCm: 29.7) with
        {
            HeaderPropertyAccessor = value => ((TestDocumentModel)value).Header,
            FooterPropertyAccessor = value => ((TestDocumentModel)value).Footer
        };
        var pdfs = new RecordingPdfGenerator();
        var renderer = CreateRenderer(descriptor, new RecordingRazorComponentRenderer(), pdfs);

        await renderer.RenderAsync(model, RenderSource.Empty);

        Assert.Equal("html:LayoutTestTemplate", pdfs.LastCall!.BodyHtml);
        Assert.Equal("html:TestHeaderComponent", pdfs.LastCall.HeaderHtml);
        Assert.Equal("html:TestFooterComponent", pdfs.LastCall.FooterHtml);
        Assert.Equal(21, pdfs.LastCall.WidthCm);
        Assert.Equal(29.7, pdfs.LastCall.HeightCm);
    }

    private static DocumentRenderer CreateRenderer(
        DocumentTemplateDescriptor descriptor,
        RecordingRazorComponentRenderer components,
        RecordingPdfGenerator pdfs)
    {
        var registry = new DocumentTemplateCatalog([descriptor]);
        var selector = new DocumentTemplateSelector(registry, []);
        return new DocumentRenderer(components, selector, registry, pdfs);
    }
}
