using Outputs.Documents.Domain.Documents;
using CttDispatchSheetContract = Outputs.Documents.Domain.Contracts.DOCE.DC003CttDispatchSheet;
using CttDispatchSheetEntryContract = Outputs.Documents.Domain.Contracts.DOCE.DC003CttDispatchEntry;

namespace Outputs.Documents.Domain.Samples.DOCE.DC003CttDispatchSheet;

public sealed class DefaultCttDispatchSheetSample : IDocumentModelSample<CttDispatchSheetContract>
{
    public CttDispatchSheetContract Create()
    {
        return new CttDispatchSheetContract(
            new DocumentTraceId
            {
                Line1 = "DC003",
                Line2 = "CTT dispatch sample"
            },
            "AUTORIZACAO",
            "CTT-2026-0001",
            "Guia de Remessa CTT",
            "Relacao",
            "2026/00042",
            "15/05/2026",
            "Fidelidade",
            "Largo do Calhariz, 30 - 1249-001 Lisboa",
            [
                new CttDispatchSheetEntryContract(
                    "Joao Pereira",
                    "Rua das Flores, 12 - 1000-001 Lisboa",
                    "1000-001",
                    "AU12345678",
                    "RR000000001PT"),
                new CttDispatchSheetEntryContract(
                    "Empresa Exemplo, Lda.",
                    "Avenida Central, 45 - 4000-100 Porto",
                    "4000-100",
                    "MR87654321",
                    "RR000000002PT")
            ],
            new Footer())
        {
            Header = new Header("fidelidade.png", "CTT dispatch", "Sample data")
        };
    }
}
