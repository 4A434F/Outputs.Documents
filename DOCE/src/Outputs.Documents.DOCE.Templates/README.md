# Outputs.Documents.DOCE.Templates

DOCE Razor document templates.

This project owns DOCE-specific Razor components marked with `DocumentTemplateAttribute`. It renders DOCE contracts by composing shared components from `Outputs.Documents.Components`.

## Status

- Maturity: origin template library
- Runtime: .NET 8 Razor class library
- Output: Razor components and static assets

## Fast Start

Build from the repository root:

```bash
dotnet build DOCE/src/Outputs.Documents.DOCE.Templates/Outputs.Documents.DOCE.Templates.csproj
```

Run DOCE template tests:

```bash
dotnet test DOCE/tests/Outputs.Documents.DOCE.Templates.UnitTests/Outputs.Documents.DOCE.Templates.UnitTests.csproj
dotnet test DOCE/tests/Outputs.Documents.DOCE.Templates.IntegrationTests/Outputs.Documents.DOCE.Templates.IntegrationTests.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `CoverPageTemplate.razor` | Cover page template |
| `CourtesyLetterTemplate.razor` | Courtesy letter template |
| `DividerTemplate.razor` | Divider template |
| `CTTDispatchSheetTemplate.razor` | CTT dispatch sheet template |
| `DeliveryNoteTemplate.razor` | Delivery note template |
| `RegTicketPageTemplate.razor` | Registered ticket page template |
| `wwwroot/` | DOCE-specific template assets |

## Architecture Summary

```text
DOCE contract
  -> DOCE Razor template
  -> shared layouts/components
  -> HTML/PDF rendering
```

Templates own render metadata through `DocumentTemplateAttribute`. The contract model remains free from render attributes.

## Usage

Register templates:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly);
```

Template shape:

```razor
@attribute [DocumentTemplate(
    isDefault: true,
    Key = "doce-courtesy-letter",
    Name = "Courtesy Letter",
    Group = "DOCE")]

@code {
    [Parameter]
    public DC001CourtesyLetter Model { get; set; } = default!;
}
```

## Service Flow

```text
WithDocumentsFromAssembly(DOCE templates)
  -> DocumentScanner
  -> DocumentTemplateDescriptor
  -> template registry
  -> DynamicComponent or renderer
```

## Project Rules

- Keep concrete DOCE templates here.
- Do not put contract classes here.
- Do not put sample data here.
- Use shared layouts/components for reusable document structure.
- Keep DOCE-specific wording and presentation here.
- Every production template should declare `DocumentTemplateAttribute`.

## Related Documentation

- [DOCE workspace README](/Users/thepotato/Code/Outputs.Documents/DOCE/README.md)
- [Components README](/Users/thepotato/Code/Outputs.Documents/Core/src/Outputs.Documents.Components/README.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
