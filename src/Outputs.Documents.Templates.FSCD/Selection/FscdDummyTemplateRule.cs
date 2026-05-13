using Outputs.Documents.Abstractions;

namespace Outputs.Documents.Templates.FSCD;

/// <summary>
/// Example selection rule showing how FSCD templates can opt into source-aware selection.
/// Normal renders are left untouched because the rule returns null unless the source
/// explicitly asks for the dummy operation.
/// </summary>
public sealed class FscdDummyTemplateRule : IDocumentTemplateSelectionRule<FscdDocumentModel>
{
    public Type? SelectTemplate(FscdDocumentModel model, RenderSource source)
    {
        return string.Equals(source.Operation, "fscd-dummy", StringComparison.OrdinalIgnoreCase)
            ? typeof(FscdDocumentTemplate)
            : null;
    }
}
