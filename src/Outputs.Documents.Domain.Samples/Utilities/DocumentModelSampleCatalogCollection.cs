namespace Outputs.Documents.Domain.Samples;

public sealed class DocumentModelSampleCatalogCollection(IEnumerable<DocumentModelSampleCatalog> catalogs)
    : IDocumentModelSampleCatalog
{
    private readonly IReadOnlyList<DocumentModelSampleCatalog> _catalogs = catalogs.ToArray();

    public IReadOnlyList<DocumentModelSampleDescriptor> GetSamples(Type modelType)
    {
        ArgumentNullException.ThrowIfNull(modelType);

        return _catalogs
            .SelectMany(catalog => catalog.GetSamples(modelType))
            .OrderBy(sample => sample.Name, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    public DocumentModelSampleDescriptor? GetSampleByName(Type modelType, string name)
    {
        ArgumentNullException.ThrowIfNull(modelType);

        if (string.IsNullOrWhiteSpace(name))
        {
            return null;
        }

        var matches = _catalogs
            .Select(catalog => catalog.GetSampleByName(modelType, name))
            .Where(sample => sample is not null)
            .Cast<DocumentModelSampleDescriptor>()
            .ToArray();

        return matches.Length switch
        {
            0 => null,
            1 => matches[0],
            _ => throw new InvalidOperationException(
                $"More than one document model sample named '{name}' was found for model '{modelType.FullName}'.")
        };
    }

    public object GetEmpty(Type modelType)
    {
        ArgumentNullException.ThrowIfNull(modelType);

        return Activator.CreateInstance(modelType)
            ?? throw new InvalidOperationException(
                $"Could not create empty sample for '{modelType.FullName}'.");
    }
}
