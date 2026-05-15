using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Rendering.Tests;

public sealed class DocumentTemplateCatalogTests
{
    [Fact]
    public void GetDefault_ReturnsOnlyRegisteredTemplateWhenNoneMarkedDefault()
    {
        var descriptor = TestDescriptors.Create<TestDocumentModel, AlternateTestTemplate>();
        var registry = new DocumentTemplateCatalog([descriptor]);

        Assert.Same(descriptor, registry.GetDefault(typeof(TestDocumentModel)));
    }

    [Fact]
    public void GetDefault_ReturnsMarkedDefaultWhenMultipleTemplatesExist()
    {
        var defaultDescriptor = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(isDefault: true);
        var alternateDescriptor = TestDescriptors.Create<TestDocumentModel, AlternateTestTemplate>();
        var registry = new DocumentTemplateCatalog([defaultDescriptor, alternateDescriptor]);

        Assert.Same(defaultDescriptor, registry.GetDefault(typeof(TestDocumentModel)));
    }

    [Fact]
    public void Constructor_ThrowsForDuplicateTemplateTypes()
    {
        var first = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>();
        var second = TestDescriptors.Create<OtherDocumentModel, DefaultTestTemplate>();

        var exception = Assert.Throws<InvalidOperationException>(() =>
            new DocumentTemplateCatalog([first, second]));

        Assert.Contains(nameof(DefaultTestTemplate), exception.Message);
        Assert.Contains("already registered", exception.Message);
    }

    [Fact]
    public void Constructor_ThrowsForMultipleDefaultsForSameModel()
    {
        var first = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(isDefault: true);
        var second = TestDescriptors.Create<TestDocumentModel, AlternateTestTemplate>(isDefault: true);

        var exception = Assert.Throws<InvalidOperationException>(() =>
            new DocumentTemplateCatalog([first, second]));

        Assert.Contains("more than one default", exception.Message);
    }

    [Fact]
    public void GetDefault_ThrowsWhenMultipleTemplatesHaveNoDefault()
    {
        var first = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>();
        var second = TestDescriptors.Create<TestDocumentModel, AlternateTestTemplate>();
        var registry = new DocumentTemplateCatalog([first, second]);

        var exception = Assert.Throws<InvalidOperationException>(() =>
            registry.GetDefault(typeof(TestDocumentModel)));

        Assert.Contains("none is marked as default", exception.Message);
    }

    [Fact]
    public void GetByTemplateType_ThrowsForUnknownTemplate()
    {
        var registry = new DocumentTemplateCatalog([]);

        var exception = Assert.Throws<InvalidOperationException>(() =>
            registry.GetByTemplateType(typeof(DefaultTestTemplate)));

        Assert.Contains("not registered", exception.Message);
    }

    [Fact]
    public void GetAll_ReturnsAllRegisteredTemplatesOrderedForDisplay()
    {
        var first = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>();
        var second = TestDescriptors.Create<OtherDocumentModel, OtherModelTemplate>();
        var registry = new DocumentTemplateCatalog([second, first]);

        Assert.Equal(
            [typeof(DefaultTestTemplate), typeof(OtherModelTemplate)],
            registry.GetAll().Select(descriptor => descriptor.BodyTemplateType));
    }
}
