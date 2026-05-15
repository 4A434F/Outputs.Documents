namespace Outputs.Documents.Domain.Samples;

public sealed class DocumentModelSampleCatalog
{
    private readonly Dictionary<Type, List<DocumentModelSampleDescriptor>> _descriptorsByModelType = [];
    private readonly HashSet<Type> _sampleTypes = [];

    public DocumentModelSampleCatalog(string assemblyName, IEnumerable<DocumentModelSampleDescriptor> descriptors)
    {
        AssemblyName = assemblyName;
        ArgumentNullException.ThrowIfNull(descriptors);

        foreach (var descriptor in descriptors)
        {
            Add(descriptor);
        }
    }

    public string AssemblyName { get; }

    private void Add(DocumentModelSampleDescriptor descriptor)
    {
        if (!_sampleTypes.Add(descriptor.SampleType))
        {
            throw new InvalidOperationException(
                $"Document model sample '{descriptor.SampleType.FullName}' is already registered.");
        }

        if (!_descriptorsByModelType.TryGetValue(descriptor.ModelType, out var modelDescriptors))
        {
            modelDescriptors = [];
            _descriptorsByModelType.Add(descriptor.ModelType, modelDescriptors);
        }

        if (modelDescriptors.Any(existing =>
                string.Equals(existing.Name, descriptor.Name, StringComparison.OrdinalIgnoreCase)))
        {
            throw new InvalidOperationException(
                $"Model '{descriptor.ModelType.FullName}' already has a document sample named '{descriptor.Name}'.");
        }

        modelDescriptors.Add(descriptor);
        modelDescriptors.Sort((left, right) =>
            string.Compare(left.Name, right.Name, StringComparison.OrdinalIgnoreCase));
    }

    public IReadOnlyList<DocumentModelSampleDescriptor> GetSamples(Type modelType)
    {
        ArgumentNullException.ThrowIfNull(modelType);

        return _descriptorsByModelType.TryGetValue(modelType, out var modelDescriptors)
            ? modelDescriptors
            : [];
    }

    public DocumentModelSampleDescriptor? GetSampleByName(Type modelType, string name)
    {
        ArgumentNullException.ThrowIfNull(modelType);

        if (string.IsNullOrWhiteSpace(name))
        {
            return null;
        }

        var normalizedName = Normalize(name);
        return GetSamples(modelType).FirstOrDefault(descriptor =>
            string.Equals(Normalize(descriptor.Name), normalizedName, StringComparison.OrdinalIgnoreCase));
    }

    private static string Normalize(string value)
    {
        return value.Trim().Replace(" ", string.Empty, StringComparison.Ordinal).ToLowerInvariant();
    }
}
