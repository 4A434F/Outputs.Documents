using Outputs.Documents.Domain;

namespace Outputs.Documents.Domain.Doce;

public class DoceCourtesyLetter : IDocumentModel
{
    public Header? Header { get; set; }
    public Address? Address { get; set; }
    public DateTime Date { get; set; }
    public DocumentTraceId TraceText { get; set; } = new() { Line1 = "Line 1", Line2 = "Line 2" };
    public Footer Footer { get; set; } = new();
    public string? AgentNumber { get; set; }
}
