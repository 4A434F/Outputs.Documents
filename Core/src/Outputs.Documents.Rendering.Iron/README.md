# Outputs.Documents.Rendering.Iron

IronPDF implementation of `IPdfGenerator`.

This provider converts composed HTML into PDF bytes using IronPDF. The core rendering project depends only on `IPdfGenerator`; hosts opt into IronPDF by referencing this project and calling the builder extension.

## Status

- Maturity: provider library
- Runtime: .NET 8
- Output: class library
- External dependency: IronPDF
- Important warning: integration flows may require a valid IronPDF license

## Fast Start

Reference this project from a host or test fixture that wants IronPDF output.

Build from the repository root:

```bash
dotnet build Core/src/Outputs.Documents.Rendering.Iron/Outputs.Documents.Rendering.Iron.csproj
```

Run focused tests:

```bash
dotnet test Core/tests/Outputs.Documents.Rendering.Iron.UnitTests/Outputs.Documents.Rendering.Iron.UnitTests.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `IronPdfGenerator.cs` | Concrete `IPdfGenerator` implementation |
| `IronPdfGeneratorOptions.cs` | Provider-specific options |
| `IronPdfGeneratorBuilderExtensions.cs` | Fluent registration extension for `RazorDocumentRenderingBuilder` |

## Architecture Summary

IronPDF is an output provider. It does not discover templates, select templates, or render Razor components.

```text
DocumentRenderer
  -> HTML body/header/footer
  -> IPdfGenerator
  -> IronPdfGenerator
  -> PDF bytes
```

## Usage

Register IronPDF with the rendering chain:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(SomeTemplate).Assembly)
    .WithIronPdfGenerator(options =>
    {
        options.LicenseKey = "...";
    });
```

## Service Flow

```text
WithIronPdfGenerator(...)
  -> optional IronPdfGeneratorOptions configuration
  -> WithPdfGenerator<IronPdfGenerator>()
  -> IPdfGenerator registered
  -> IDocumentRenderer registered by rendering builder
```

## Project Rules

- Keep IronPDF-specific APIs and options here.
- Do not put generic rendering orchestration here.
- Do not reference origin projects.
- Do not put template selection or Razor component scanning here.
- Do not make core rendering depend on this provider.

## Development Workflow

1. Keep provider behavior behind `IPdfGenerator`.
2. Add unit tests for options and DI registration.
3. Use provider integration tests in origin workspaces for real PDF output.
4. Update this README when provider options or registration change.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Rendering README](/Users/thepotato/Code/Outputs.Documents/Core/src/Outputs.Documents.Rendering/README.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
