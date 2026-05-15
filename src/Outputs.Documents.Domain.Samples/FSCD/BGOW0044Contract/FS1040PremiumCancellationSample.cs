using Outputs.Documents.Domain.Contracts.FSCD;

namespace Outputs.Documents.Domain.Samples.FSCD.BGOW0044Contract;

public sealed class FS1040PremiumCancellationSample : IDocumentModelSample<Contracts.FSCD.BGOW0044Contract>
{
    public Contracts.FSCD.BGOW0044Contract Create()
    {
        return new Contracts.FSCD.BGOW0044Contract
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
