namespace Outputs.Documents.Abstractions;

/// <summary>
/// Type-safe helper contract for writing document template selection rules.
/// Implement this interface in application/template packages so rule code can work
/// with a strongly typed model while the selector still consumes the non-generic
/// <see cref="IDocumentTemplateSelectionRule" /> pipeline contract.
/// </summary>
/// <typeparam name="TModel">The document model type this rule evaluates.</typeparam>
public interface IDocumentTemplateSelectionRule<TModel> : IDocumentTemplateSelectionRule
{
    /// <inheritdoc />
    Type IDocumentTemplateSelectionRule.ModelType => typeof(TModel);

    /// <inheritdoc />
    Type? IDocumentTemplateSelectionRule.SelectTemplate(object model, RenderSource source)
    {
        return model is TModel typedModel
            ? SelectTemplate(typedModel, source)
            : null;
    }

    /// <summary>
    /// Returns the selected template component type for the strongly typed model and render source,
    /// or <see langword="null" /> when this rule does not select a template.
    /// </summary>
    Type? SelectTemplate(TModel model, RenderSource source);
}
