namespace Outputs.Documents.Abstractions;

public interface IDocumentTemplateRegistry
{
    void Add(DocumentTemplateDescriptor descriptor);

    DocumentTemplateDescriptor GetByTemplateType(Type templateType);

    DocumentTemplateDescriptor GetDefault(Type modelType);

    IReadOnlyList<DocumentTemplateDescriptor> GetAll(Type modelType);

    IReadOnlyList<DocumentTemplateDescriptor> GetAll();
}
