using Outputs.Documents.Abstractions;
using Outputs.Documents.Rendering;

namespace Outputs.Documents.Rendering.UnitTests;

public sealed class DocumentTemplateSelectorTests
{
    [Fact]
    public void Select_UsesDefaultWhenNoRuleReturnsTemplate()
    {
        var defaultDescriptor = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(isDefault: true);
        var selectedDescriptor = TestDescriptors.Create<TestDocumentModel, AlternateTestTemplate>();
        var selector = CreateSelector([defaultDescriptor, selectedDescriptor], [new NullRule()]);

        var descriptor = selector.Select(new TestDocumentModel(), RenderSource.Empty);

        Assert.Same(defaultDescriptor, descriptor);
    }

    [Fact]
    public void Select_UsesSelectedTemplateWhenOneRuleReturnsType()
    {
        var defaultDescriptor = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(isDefault: true);
        var selectedDescriptor = TestDescriptors.Create<TestDocumentModel, AlternateTestTemplate>();
        var selector = CreateSelector([defaultDescriptor, selectedDescriptor], [new SelectAlternateRule()]);

        var descriptor = selector.Select(new TestDocumentModel(), new RenderSource(IsPreview: true));

        Assert.Same(selectedDescriptor, descriptor);
    }

    [Fact]
    public void Select_AllowsMultipleRulesReturningSameTemplateType()
    {
        var defaultDescriptor = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(isDefault: true);
        var selectedDescriptor = TestDescriptors.Create<TestDocumentModel, AlternateTestTemplate>();
        var selector = CreateSelector(
            [defaultDescriptor, selectedDescriptor],
            [new SelectAlternateRule(), new AlsoSelectAlternateRule()]);

        var descriptor = selector.Select(new TestDocumentModel(), new RenderSource(IsPreview: true));

        Assert.Same(selectedDescriptor, descriptor);
    }

    [Fact]
    public void Select_ThrowsWhenMultipleDifferentTemplatesAreSelected()
    {
        var defaultDescriptor = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(isDefault: true);
        var selectedDescriptor = TestDescriptors.Create<TestDocumentModel, AlternateTestTemplate>();
        var selector = CreateSelector(
            [defaultDescriptor, selectedDescriptor],
            [new SelectDefaultRule(), new SelectAlternateRule()]);

        var exception = Assert.Throws<InvalidOperationException>(() =>
            selector.Select(new TestDocumentModel(), new RenderSource(IsPreview: true)));

        Assert.Contains("Multiple document templates", exception.Message);
        Assert.Contains(nameof(SelectDefaultRule), exception.Message);
        Assert.Contains(nameof(SelectAlternateRule), exception.Message);
    }

    [Fact]
    public void Select_ThrowsWhenRuleReturnsUnregisteredTemplateType()
    {
        var defaultDescriptor = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(isDefault: true);
        var selector = CreateSelector([defaultDescriptor], [new SelectUnregisteredRule()]);

        var exception = Assert.Throws<InvalidOperationException>(() =>
            selector.Select(new TestDocumentModel(), RenderSource.Empty));

        Assert.Contains("not registered", exception.Message);
    }

    [Fact]
    public void Select_ThrowsWhenRuleReturnsTemplateForDifferentModelType()
    {
        var defaultDescriptor = TestDescriptors.Create<TestDocumentModel, DefaultTestTemplate>(isDefault: true);
        var wrongModelDescriptor = TestDescriptors.Create<OtherDocumentModel, OtherModelTemplate>(isDefault: true);
        var selector = CreateSelector([defaultDescriptor, wrongModelDescriptor], [new SelectOtherModelTemplateRule()]);

        var exception = Assert.Throws<InvalidOperationException>(() =>
            selector.Select(new TestDocumentModel(), RenderSource.Empty));

        Assert.Contains("registered for model", exception.Message);
    }

    private static DocumentTemplateSelector CreateSelector(
        IEnumerable<DocumentTemplateDescriptor> descriptors,
        IEnumerable<IDocumentTemplateSelectionRule> rules)
    {
        return new DocumentTemplateSelector(new DocumentTemplateCatalog(descriptors), rules);
    }
}
