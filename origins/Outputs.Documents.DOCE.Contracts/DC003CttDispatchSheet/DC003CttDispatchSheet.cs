using Outputs.Documents.Domain.Documents;

namespace Outputs.Documents.DOCE.Contracts;

[DomainSearch(
    "DC003 CTT Dispatch Sheet",
    "DOCE CTT dispatch sheet contract with authorization, relation, sender, recipient entries, trace, and footer.",
    Aliases = ["CTT dispatch sheet", "dispatch sheet", "guia CTT", "postal dispatch"],
    Tags = ["contract", "doce", "DC003", "ctt", "dispatch"])]
public class DC003CttDispatchSheet(
    DocumentTraceId traceId,
    string authorizationLabel,
    string authorizationCode,
    string title,
    string relationLabel,
    string relationNumber,
    string date,
    string senderName,
    string senderAddress,
    List<DC003CttDispatchEntry>? entries,
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
    public List<DC003CttDispatchEntry>? Entries { get; set; } = entries;
    public Footer Footer { get; set; } = footer ?? new();
}

[DomainSearch(
    "DC003 CTT Dispatch Entry",
    "Recipient dispatch entry for a DOCE CTT dispatch sheet with address, policy, and registration number.",
    Aliases = ["dispatch entry", "recipient entry", "CTT entry"],
    Tags = ["contract", "doce", "DC003", "ctt", "dispatch-entry"])]
public class DC003CttDispatchEntry(
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
