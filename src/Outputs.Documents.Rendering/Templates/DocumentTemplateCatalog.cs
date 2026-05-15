using Outputs.Documents.Abstractions;

namespace Outputs.Documents.Rendering;

public sealed class DocumentTemplateCatalog : IDocumentTemplateRegistry
{
    private readonly Dictionary<Type, DocumentTemplateDescriptor> _templatesByType = new();
    private readonly Dictionary<Type, List<DocumentTemplateDescriptor>> _templatesByModelType = new();

    public DocumentTemplateCatalog(IEnumerable<DocumentTemplateDescriptor> descriptors)
    {
        foreach (var descriptor in descriptors)
        {
            Add(descriptor);
        }
    }

    public void Add(DocumentTemplateDescriptor descriptor)
    {
        ArgumentNullException.ThrowIfNull(descriptor);

        if (_templatesByType.ContainsKey(descriptor.BodyTemplateType))
        {
            throw new InvalidOperationException(
                $"Document template '{descriptor.BodyTemplateType.FullName}' is already registered.");
        }

        if (descriptor.IsDefault
            && _templatesByModelType.TryGetValue(descriptor.ModelType, out var existing)
            && existing.Any(template => template.IsDefault))
        {
            var currentDefault = existing.First(template => template.IsDefault);
            throw new InvalidOperationException(
                $"Model '{descriptor.ModelType.FullName}' has more than one default document template: " +
                $"'{currentDefault.BodyTemplateType.FullName}' and '{descriptor.BodyTemplateType.FullName}'.");
        }

        _templatesByType.Add(descriptor.BodyTemplateType, descriptor);

        if (!_templatesByModelType.TryGetValue(descriptor.ModelType, out var descriptors))
        {
            descriptors = new List<DocumentTemplateDescriptor>();
            _templatesByModelType.Add(descriptor.ModelType, descriptors);
        }

        descriptors.Add(descriptor);
    }

    public DocumentTemplateDescriptor GetByTemplateType(Type templateType)
    {
        ArgumentNullException.ThrowIfNull(templateType);

        if (_templatesByType.TryGetValue(templateType, out var descriptor))
        {
            return descriptor;
        }

        throw new InvalidOperationException(
            $"Document template '{templateType.FullName}' is not registered.");
    }

    public DocumentTemplateDescriptor GetDefault(Type modelType)
    {
        var descriptors = GetAll(modelType);

        if (descriptors.Count == 1)
        {
            return descriptors[0];
        }

        var defaults = descriptors.Where(template => template.IsDefault).ToArray();
        return defaults.Length switch
        {
            1 => defaults[0],
            0 => throw new InvalidOperationException(
                $"Model '{modelType.FullName}' has {descriptors.Count} registered document templates but none is marked as default."),
            _ => throw new InvalidOperationException(
                $"Model '{modelType.FullName}' has multiple default document templates: " +
                string.Join(", ", defaults.Select(template => $"'{template.BodyTemplateType.FullName}'")))
        };
    }

    public IReadOnlyList<DocumentTemplateDescriptor> GetAll(Type modelType)
    {
        ArgumentNullException.ThrowIfNull(modelType);

        if (_templatesByModelType.TryGetValue(modelType, out var descriptors))
        {
            return descriptors;
        }

        throw new InvalidOperationException(
            $"No document templates are registered for model '{modelType.FullName}'.");
    }

    public IReadOnlyList<DocumentTemplateDescriptor> GetAll()
    {
        return _templatesByType.Values
            .OrderBy(descriptor => descriptor.Group, StringComparer.OrdinalIgnoreCase)
            .ThenBy(descriptor => descriptor.Name, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }
}
