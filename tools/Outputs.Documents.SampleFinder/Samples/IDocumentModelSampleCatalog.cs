namespace Outputs.Documents.SampleFinder;

public interface IDocumentModelSampleCatalog
{
    IReadOnlyList<DocumentModelSampleDescriptor> GetSamples(Type modelType);

    DocumentModelSampleDescriptor? GetSampleByName(Type modelType, string name);

    object GetEmpty(Type modelType);
}
