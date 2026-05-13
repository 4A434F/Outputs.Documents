using Outputs.Documents.Abstractions;

namespace Outputs.Documents.Templates.FSCD;

public sealed class CourtesyLetterPreviewTemplateRule : IDocumentTemplateSelectionRule<CourtesyLetter>
{
    public Type? SelectTemplate(CourtesyLetter model, RenderSource source)
    {
        return source.IsPreview
            ? typeof(CourtesyLetterPreviewTemplate)
            : null;
    }
}
