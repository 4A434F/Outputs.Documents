using Outputs.Documents.Domain.Documents;
using Outputs.Documents.Domain.Locations;
using CourtesyLetterContract = Outputs.Documents.Domain.Contracts.DOCE.DC001CourtesyLetter;

namespace Outputs.Documents.Domain.Samples.DOCE.DC001CourtesyLetter;

public sealed class DefaultCourtesyLetterSample : IDocumentModelSample<CourtesyLetterContract>
{
    public CourtesyLetterContract Create()
    {
        return new CourtesyLetterContract
        {
            Header = new Header("fidelidade.png", "Courtesy letter", "Sample data"),
            Address = new PostalAddress
            {
                Name = "Maria Silva",
                Line1 = "Rua das Flores, 12",
                Locality = "Lisboa",
                PostalCode = "1000-001",
                PostalCodeDescription = "Lisboa",
                CountryCode = "PT",
                CountryDescription = "Portugal"
            },
            Date = new DateTime(2026, 5, 15),
            TraceText = new DocumentTraceId
            {
                Line1 = "DC001",
                Line2 = "Courtesy letter sample"
            },
            AgentNumber = "0001234567"
        };
    }
}
