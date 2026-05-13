using Outputs.Documents.Rendering;

namespace Outputs.Documents.Rendering.Tests;

public sealed class DocumentScannerTests
{
    [Fact]
    public void CreateDescriptor_InfersModelTypeFromParameter()
    {
        var descriptor = DocumentScanner.CreateDescriptor(typeof(DefaultTestTemplate));

        Assert.NotNull(descriptor);
        Assert.Equal(typeof(TestDocumentModel), descriptor.ModelType);
        Assert.Equal(typeof(DefaultTestTemplate), descriptor.BodyTemplateType);
        Assert.True(descriptor.IsDefault);
        Assert.Equal("Model", descriptor.ModelParameterName);
    }

    [Fact]
    public void CreateDescriptor_BuildsLayoutDescriptorWithPrecomputedAccessors()
    {
        var descriptor = DocumentScanner.CreateDescriptor(typeof(LayoutTestTemplate));
        var model = new TestDocumentModel
        {
            Header = new TestHeaderModel { Text = "header" },
            Footer = new TestFooterModel { Text = "footer" }
        };

        Assert.NotNull(descriptor);
        Assert.Equal(typeof(TestHeaderComponent), descriptor.HeaderTemplateType);
        Assert.Equal(typeof(TestFooterComponent), descriptor.FooterTemplateType);
        Assert.Equal(nameof(TestDocumentModel.Header), descriptor.HeaderPropertyName);
        Assert.Equal(nameof(TestDocumentModel.Footer), descriptor.FooterPropertyName);
        Assert.Same(model.Header, descriptor.HeaderPropertyAccessor!(model));
        Assert.Same(model.Footer, descriptor.FooterPropertyAccessor!(model));
    }

    [Fact]
    public void CreateDescriptor_ThrowsWhenModelParameterIsMissing()
    {
        var exception = Assert.Throws<InvalidOperationException>(() =>
            DocumentScanner.CreateDescriptor(typeof(MissingModelParameterTemplate)));

        Assert.Contains(nameof(MissingModelParameterTemplate), exception.Message);
        Assert.Contains("Model", exception.Message);
    }

    [Fact]
    public void CreateDescriptor_ThrowsWhenModelParameterIsNotAParameter()
    {
        var exception = Assert.Throws<InvalidOperationException>(() =>
            DocumentScanner.CreateDescriptor(typeof(NotMarkedParameterTemplate)));

        Assert.Contains(nameof(NotMarkedParameterTemplate), exception.Message);
        Assert.Contains("[Parameter]", exception.Message);
    }

    [Fact]
    public void CreateDescriptor_ThrowsWhenModelParameterTypeIsObject()
    {
        var exception = Assert.Throws<InvalidOperationException>(() =>
            DocumentScanner.CreateDescriptor(typeof(ObjectModelTemplate)));

        Assert.Contains(nameof(ObjectModelTemplate), exception.Message);
        Assert.Contains("unusable", exception.Message);
    }
}
