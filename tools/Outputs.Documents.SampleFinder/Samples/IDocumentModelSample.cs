using Outputs.Documents.Abstractions;

namespace Outputs.Documents.SampleFinder;

/// <summary>
/// Creates one sample instance for a document contract model.
/// </summary>
/// <remarks>
/// Implementations should contain only sample data construction. The sample catalog infers
/// the model type and display name from this generic interface and the sample class name.
/// </remarks>
public interface IDocumentModelSample<out TModel>
    where TModel : IDocumentModel
{
    TModel Create();
}
