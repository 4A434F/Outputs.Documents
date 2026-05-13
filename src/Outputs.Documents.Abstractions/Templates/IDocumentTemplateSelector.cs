namespace Outputs.Documents.Abstractions;

public interface IDocumentTemplateSelector
{
    DocumentTemplateDescriptor Select(object model, RenderSource source);
}
