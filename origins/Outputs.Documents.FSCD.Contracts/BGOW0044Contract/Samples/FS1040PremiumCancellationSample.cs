using Outputs.Documents.FSCD.Contracts;

using Outputs.Documents.Samples;

namespace Outputs.Documents.FSCD.Contracts.Samples.BGOW0044Contract;

public sealed class FS1040PremiumCancellationSample : IDocumentModelSample<global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract>
{
    public global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract Create()
    {
        return new global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract
        {
            DocumentIdentification = "1040",
            Description = "CDC1 Cancellation Letter (FSCD) - Premium",
            PrimaryProgram = "PGOC114A",
            PrimaryCopybook = "BGOW0044",
            LayoutCode = "FS1040",
            OutputPrefix = "FS",
            Status = "Preview",
            PrimaryOverlays = "Sample preview data"
        };
    }
}
