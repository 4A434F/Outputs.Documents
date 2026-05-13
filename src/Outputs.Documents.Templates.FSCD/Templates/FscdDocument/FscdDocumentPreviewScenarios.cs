using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Templates.FSCD;

public sealed class FscdDocumentPreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new DocumentPreviewScenario(
            "default",
            "Default",
            typeof(FscdDocumentModel),
            new FscdDocumentModel { Title = "FSCD document preview" });
    }
}
