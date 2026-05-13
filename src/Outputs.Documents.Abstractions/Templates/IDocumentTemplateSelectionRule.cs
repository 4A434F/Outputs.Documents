namespace Outputs.Documents.Abstractions;

/// <summary>
/// Runtime-facing contract for document template selection rules.
/// The selector uses this non-generic interface so it can evaluate rules for models
/// without knowing any concrete document model types at compile time.
/// </summary>
public interface IDocumentTemplateSelectionRule
{
    /// <summary>
    /// Gets the document model type this rule can evaluate.
    /// </summary>
    Type ModelType { get; }

    /// <summary>
    /// Returns the selected template component type for the supplied model and render source,
    /// or <see langword="null" /> when this rule does not select a template.
    /// </summary>
    Type? SelectTemplate(object model, RenderSource source);
}
