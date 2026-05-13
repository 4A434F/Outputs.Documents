using Outputs.Documents.Abstractions;

namespace Outputs.Documents.Rendering;

public sealed class DocumentTemplateSelector(
    IDocumentTemplateRegistry registry,
    IEnumerable<IDocumentTemplateSelectionRule> rules)
    : IDocumentTemplateSelector
{
    private readonly Dictionary<Type, IDocumentTemplateSelectionRule[]> _rulesByModelType = rules
        .GroupBy(rule => rule.ModelType)
        .ToDictionary(group => group.Key, group => group.ToArray());

    public DocumentTemplateDescriptor Select(object model, RenderSource source)
    {
        ArgumentNullException.ThrowIfNull(model);
        source ??= RenderSource.Empty;

        var modelType = model.GetType();

        if (!_rulesByModelType.TryGetValue(modelType, out var modelRules) || modelRules.Length == 0)
        {
            return registry.GetDefault(modelType);
        }

        var selected = new List<SelectedTemplate>();
        foreach (var rule in modelRules)
        {
            var templateType = rule.SelectTemplate(model, source);
            if (templateType is not null)
            {
                selected.Add(new SelectedTemplate(templateType, rule.GetType()));
            }
        }

        if (selected.Count == 0)
        {
            return registry.GetDefault(modelType);
        }

        var distinctTemplateTypes = selected
            .Select(item => item.TemplateType)
            .Distinct()
            .ToArray();

        if (distinctTemplateTypes.Length > 1)
        {
            var selections = selected
                .GroupBy(item => item.TemplateType)
                .Select(group => $"{group.Key.FullName} <= {string.Join(", ", group.Select(item => item.RuleType.FullName))}");

            throw new InvalidOperationException(
                $"Multiple document templates were selected for model '{modelType.FullName}' and source [{source}]. " +
                $"Selected templates: {string.Join("; ", selections)}.");
        }

        var descriptor = registry.GetByTemplateType(distinctTemplateTypes[0]);
        if (descriptor.ModelType != modelType)
        {
            throw new InvalidOperationException(
                $"Selection rule returned template '{descriptor.BodyTemplateType.FullName}' for model '{modelType.FullName}', " +
                $"but the template is registered for model '{descriptor.ModelType.FullName}'.");
        }

        return descriptor;
    }

    private sealed record SelectedTemplate(Type TemplateType, Type RuleType);
}
