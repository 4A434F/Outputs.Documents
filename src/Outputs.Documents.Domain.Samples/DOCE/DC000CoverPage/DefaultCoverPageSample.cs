using Outputs.Documents.Domain.Contracts.DOCE;

namespace Outputs.Documents.Domain.Samples.DOCE.DC000CoverPage;

public sealed class DefaultCoverPageSample : IDocumentModelSample<Contracts.DOCE.DC000CoverPage>
{
    public Contracts.DOCE.DC000CoverPage Create()
    {
        return new Contracts.DOCE.DC000CoverPage(
            "Cartas",
            "Documentos DOCE",
            "001",
            "Lote diario de expedicao",
            "CTT",
            "Centro Operacional Lisboa",
            "Largo do Calhariz, 30",
            "1249-001 Lisboa",
            null,
            null,
            "A4",
            128,
            128,
            64,
            2,
            4,
            null,
            null,
            null,
            null,
            new DateTime(2026, 5, 15, 10, 30, 0));
    }
}
