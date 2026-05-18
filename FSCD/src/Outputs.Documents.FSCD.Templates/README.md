# Outputs.Documents.FSCD.Templates

FSCD Razor document templates and template selection rules.

This project owns FSCD-specific Razor components marked with `DocumentTemplateAttribute`, plus FSCD rules that select between templates for the same contract model.

## Status

- Maturity: origin template library
- Runtime: .NET 8 Razor class library
- Output: Razor components and selection rules

## Fast Start

Build from the repository root:

```bash
dotnet build FSCD/src/Outputs.Documents.FSCD.Templates/Outputs.Documents.FSCD.Templates.csproj
```

Run FSCD template integration tests:

```bash
dotnet test FSCD/tests/Outputs.Documents.FSCD.Templates.IntegrationTests/Outputs.Documents.FSCD.Templates.IntegrationTests.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `FS1040CancellationCdc1PremiumTemplate.razor` | FS1040 CDC1 cancellation premium letter |
| `FS1176LifeNonPaymentPolicyholderWithCreditTemplate.razor` | FS1176 life non-payment letter |
| `BGOW0044TemplateSelectionRule.cs` | FSCD selection rule for BGOW0044 templates |

## Architecture Summary

```text
FSCD contract
  -> FSCD template selection rule
  -> selected FSCD Razor template
  -> shared layouts/components
  -> HTML/PDF rendering
```

Templates own render metadata through `DocumentTemplateAttribute`. The contract model remains free from render attributes.

## Usage

Register templates and rules:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(FS1040CancellationCdc1PremiumTemplate).Assembly);
```

Template shape:

```razor
@attribute [DocumentTemplate(
    Key = "fs1040-cdc1-cancellation-letter-premium",
    Name = "CDC1 Cancellation Letter (FSCD) - Premium",
    Group = "FSCD")]

@code {
    [Parameter]
    public BGOW0044Contract Model { get; set; } = default!;
}
```

## Service Flow

```text
WithDocumentsFromAssembly(FSCD templates)
  -> DocumentScanner scans templates
  -> DocumentScanner scans selection rules
  -> descriptors and rules registered
  -> selector resolves one template at render time
```

## Project Rules

- Keep concrete FSCD templates here.
- Keep FSCD selection rules here.
- Do not put contract classes here.
- Do not put sample data here.
- Use shared layouts/components for reusable document structure.
- Keep FSCD-specific wording and presentation here.
- Every production template should declare `DocumentTemplateAttribute`.
- Rules return template component types, not string keys.

## Related Documentation

- [FSCD workspace README](/Users/thepotato/Code/Outputs.Documents/FSCD/README.md)
- [Components README](/Users/thepotato/Code/Outputs.Documents/Core/src/Outputs.Documents.Components/README.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
