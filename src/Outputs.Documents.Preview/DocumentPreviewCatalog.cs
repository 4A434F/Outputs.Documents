using Outputs.Documents.Abstractions;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Preview;

public sealed class DocumentPreviewCatalog : IDocumentPreviewCatalog
{
    private readonly IReadOnlyList<DocumentTemplateDescriptor> _templates;
    private readonly IReadOnlyList<DocumentPreviewScenario> _scenarios;

    public DocumentPreviewCatalog(
        IEnumerable<DocumentTemplateDescriptor> templates,
        IEnumerable<IDocumentPreviewScenarioProvider> scenarioProviders)
    {
        ArgumentNullException.ThrowIfNull(templates);
        ArgumentNullException.ThrowIfNull(scenarioProviders);

        _templates = templates
            .OrderBy(template => template.Group)
            .ThenBy(template => template.Name)
            .ToArray();

        _scenarios = scenarioProviders
            .SelectMany(provider => provider.GetScenarios())
            .OrderBy(scenario => scenario.Name)
            .ToArray();

        ValidateTemplates(_templates);
        ValidateScenarios(_scenarios);
    }

    public IReadOnlyList<DocumentTemplateDescriptor> Templates => _templates;

    public IReadOnlyList<DocumentPreviewScenario> Scenarios => _scenarios;

    public DocumentTemplateDescriptor? FindTemplate(string templateKey)
    {
        return _templates.FirstOrDefault(template =>
            string.Equals(template.Key, templateKey, StringComparison.OrdinalIgnoreCase));
    }

    public IReadOnlyList<DocumentPreviewScenario> GetScenariosForTemplate(
        DocumentTemplateDescriptor template)
    {
        return _scenarios
            .Where(scenario => scenario.ModelType == template.ModelType)
            .ToArray();
    }

    public DocumentPreviewScenario? FindScenario(
        DocumentTemplateDescriptor template,
        string? scenarioKey)
    {
        var scenarios = GetScenariosForTemplate(template);

        if (!string.IsNullOrWhiteSpace(scenarioKey))
        {
            var selected = scenarios.FirstOrDefault(scenario =>
                string.Equals(scenario.Key, scenarioKey, StringComparison.OrdinalIgnoreCase));

            if (selected is not null)
            {
                return selected;
            }
        }

        return scenarios.FirstOrDefault();
    }

    private static void ValidateTemplates(IEnumerable<DocumentTemplateDescriptor> templates)
    {
        var duplicates = templates
            .GroupBy(template => template.Key, StringComparer.OrdinalIgnoreCase)
            .Where(group => group.Count() > 1)
            .ToArray();

        if (duplicates.Length == 0)
        {
            return;
        }

        var duplicate = duplicates[0];
        var templateList = string.Join(
            Environment.NewLine,
            duplicate.Select(template => $"- {template.BodyTemplateType.FullName}"));

        throw new InvalidOperationException(
            $"Duplicate document template preview key '{duplicate.Key}'." +
            $"{Environment.NewLine}Templates:{Environment.NewLine}{templateList}");
    }

    private static void ValidateScenarios(IEnumerable<DocumentPreviewScenario> scenarios)
    {
        var duplicates = scenarios
            .GroupBy(scenario => new ScenarioKey(scenario.ModelType, scenario.Key))
            .Where(group => group.Count() > 1)
            .ToArray();

        if (duplicates.Length == 0)
        {
            return;
        }

        var duplicate = duplicates[0].Key;

        throw new InvalidOperationException(
            $"Duplicate document preview scenario key '{duplicate.Key}' for model '{duplicate.ModelType.FullName}'.");
    }

    private sealed record ScenarioKey(Type ModelType, string Key);
}
