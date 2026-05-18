# Outputs.Documents.Rendering

Generic Razor document rendering implementation.

This project wires together Razor component HTML rendering, template discovery, descriptor registration, template selection, and document rendering orchestration. It does not know about DOCE, FSCD, copybooks, or any specific document family.

## Status

- Maturity: core platform library
- Runtime: .NET 8
- Output: class library
- Stability expectation: high; origin-specific behavior must stay outside this project

## Fast Start

Reference this project from hosts, apps, or test fixtures that need rendering services.

Build from the repository root:

```bash
dotnet build Core/src/Outputs.Documents.Rendering/Outputs.Documents.Rendering.csproj
```

Run focused tests:

```bash
dotnet test Core/tests/Outputs.Documents.Rendering.UnitTests/Outputs.Documents.Rendering.UnitTests.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `Registration/` | Assembly scanning and DI extension methods |
| `Rendering/` | Razor-to-HTML renderer and high-level document renderer |
| `Templates/` | Template catalog/registry and selector implementation |

## Architecture Summary

Reflection happens during discovery. Runtime rendering uses precomputed descriptors.

```text
host registers assemblies
  -> DocumentScanner builds descriptors
  -> DocumentTemplateCatalog stores descriptors
  -> DocumentRenderer receives model + RenderSource
  -> DocumentTemplateSelector picks one descriptor
  -> RazorComponentHtmlRenderer renders body/header/footer
  -> IPdfGenerator creates PDF bytes
```

## Usage

Register rendering and templates:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(SomeTemplate).Assembly)
    .WithPdfGenerator<SomePdfGenerator>();
```

Render a known component directly to HTML:

```csharp
var html = await razorRenderer.RenderAsync(
    typeof(SomeTemplate),
    model,
    parameterName: "Model",
    cancellationToken);
```

Render through the full document pipeline:

```csharp
var pdf = await documentRenderer.RenderAsync(
    model,
    new RenderSource(IsPreview: true),
    cancellationToken);
```

## Service Flow

```text
AddRazorDocumentRendering()
  -> AddRazorComponentRendering()
  -> IDocumentTemplateRegistry = DocumentTemplateCatalog
  -> IDocumentTemplateSelector = DocumentTemplateSelector

WithDocumentsFromAssembly(...)
  -> DocumentScanner.ScanTemplates(...)
  -> add DocumentTemplateDescriptor instances
  -> DocumentScanner.ScanSelectionRules(...)
  -> add IDocumentTemplateSelectionRule implementations

WithPdfGenerator(...)
  -> IPdfGenerator
  -> IDocumentRenderer = DocumentRenderer
```

## Project Rules

- Do not reference origin projects.
- Do not hard-code document families, copybook names, or concrete origin template types.
- Do not implement PDF provider-specific logic here.
- Keep reflection in registration/scanning paths, not render paths.
- Use `DocumentTemplateDescriptor` at runtime rather than reading attributes during render.
- Template selection must return zero or one distinct template type.
- Multiple different selected template types must throw a clear exception.

## Development Workflow

1. Add or update unit tests for scanner, catalog, selector, and renderer behavior.
2. Keep public contracts in `Outputs.Documents.Abstractions`.
3. Keep provider-specific PDF behavior in provider projects.
4. Update this README when registration or render flow changes.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
