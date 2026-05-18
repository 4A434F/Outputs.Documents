using Outputs.Documents.Domain.Documents;
using Outputs.Documents.Domain.Documents.Primitives;
using Outputs.Documents.Domain.Locations;
using DeliveryNoteContract = Outputs.Documents.DOCE.Contracts.DC004DeliveryNote;

using Outputs.Documents.Abstractions.Samples;

namespace Outputs.Documents.DOCE.Contracts.Samples.DC004DeliveryNote;

public sealed class DefaultDeliveryNoteSample : IDocumentModelSample<DeliveryNoteContract>
{
    public DeliveryNoteContract Create()
    {
        var model = new DeliveryNoteContract
        {
            Header = new Header("fidelidade.png", "Delivery note", "Sample data"),
            Address = new PostalAddress
            {
                Name = "Mediador Exemplo",
                Line1 = "Rua das Flores, 12",
                Locality = "Lisboa",
                PostalCode = "1000-001",
                PostalCodeDescription = "Lisboa"
            },
            Date = new DateTime(2026, 5, 15),
            DeliveryNoteNumber = "NE-2026-0001",
            AgentNumber = "0001234567"
        };

        model.Table.Rows =
        [
            new CustomTableRow
            {
                Cells = ["Automovel", "AU12345678", "REC000001", "Premio", 125.35m, 12.53m]
            },
            new CustomTableRow
            {
                Cells = ["Multirriscos", "MR87654321", "REC000002", "Premio", 240.10m, 24.01m]
            }
        ];

        return model;
    }
}
