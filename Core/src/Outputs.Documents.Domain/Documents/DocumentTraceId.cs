namespace Outputs.Documents.Domain.Documents;

[DomainSearch(
    "Document trace id",
    "Reusable print trace identifier rendered on the side of generated document pages.",
    Aliases = ["trace id", "document trace", "print trace", "DocumentTraceID"],
    Tags = ["common", "document", "trace"])]
public sealed class DocumentTraceId
{
    [DomainSearch(
        "Trace id",
        "Template or document identifier shown in the trace line.",
        Aliases = ["Id", "TraceId"],
        Tags = ["field", "document", "trace"])]
    public string? Id { get; init; }

    [DomainSearch(
        "Trace date",
        "Date and time shown in the trace line.",
        Aliases = ["TraceDate", "print date"],
        Tags = ["field", "document", "trace"])]
    public DateTime? Date { get; init; }

    [DomainSearch(
        "Trace environment",
        "Environment code shown in the trace line.",
        Aliases = ["TraceEnvironment", "Env"],
        Tags = ["field", "document", "trace"])]
    public string? Environment { get; init; }

    [DomainSearch(
        "Trace program",
        "Program name shown in the second trace line.",
        Aliases = ["TraceProgram", "Program"],
        Tags = ["field", "document", "trace"])]
    public string? Program { get; init; }

    [DomainSearch(
        "Trace user",
        "User name shown in the second trace line.",
        Aliases = ["TraceUser", "User"],
        Tags = ["field", "document", "trace"])]
    public string? User { get; init; }
}
