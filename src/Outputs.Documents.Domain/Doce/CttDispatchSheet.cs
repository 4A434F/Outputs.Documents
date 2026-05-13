using Outputs.Documents.Domain;

namespace Outputs.Documents.Domain.Doce;

public class CttDispatchSheet(
    DocumentTraceId traceId,
    string authorizationLabel,
    string authorizationCode,
    string title,
    string relationLabel,
    string relationNumber,
    string date,
    string senderName,
    string senderAddress,
    List<CttDispatchEntry>? entries,
    Footer? footer = null,
    string? employeeLabel = null) : IDocumentModel
{
    public DocumentTraceId TraceID { get; set; } = traceId;
    public Header? Header { get; set; }
    public string AuthorizationLabel { get; set; } = authorizationLabel;
    public string AuthorizationCode { get; set; } = authorizationCode;
    public string Title { get; set; } = title;
    public string RelationLabel { get; set; } = relationLabel;
    public string RelationNumber { get; set; } = relationNumber;
    public string Date { get; set; } = date;
    public string EmployeeLabel { get; set; } = employeeLabel ?? "O EMPREGADO";
    public string SenderName { get; set; } = senderName;
    public string SenderAddress { get; set; } = senderAddress;
    public List<CttDispatchEntry>? Entries { get; set; } = entries;
    public Footer Footer { get; set; } = footer ?? new();
}

public class CttDispatchEntry(
    string recipientName,
    string recipientAddress,
    string postalCode,
    string policyNumber,
    string registrationNumber)
{
    public string RecipientName { get; set; } = recipientName;
    public string RecipientAddress { get; set; } = recipientAddress;
    public string PostalCode { get; set; } = postalCode;
    public string PolicyNumber { get; set; } = policyNumber;
    public string RegistrationNumber { get; set; } = registrationNumber;
}
