# Outputs.Documents.Rendering.Iron

IronPDF implementation of `IPdfGenerator`.

This provider converts composed HTML into PDF bytes using IronPDF. The main rendering project depends only on `IPdfGenerator`; hosts opt into IronPDF by referencing this project and calling its builder extension.

## What Lives Here

- `IronPdfGenerator`: concrete `IPdfGenerator` implementation.
- `IronPdfGeneratorOptions`: provider-specific options.
- `IronPdfGeneratorBuilderExtensions`: registration extension for `RazorDocumentRenderingBuilder`.

## Rules

- Keep IronPDF-specific APIs and options here.
- Do not put generic document rendering orchestration here.
- Do not reference origin projects.
- Do not put template selection or Razor component scanning here.

## Dependency Direction

Allowed:

```text
Rendering.Iron -> Abstractions
Host -> Rendering.Iron
```

Avoid:

```text
Rendering -> Rendering.Iron
Origin Templates -> Rendering.Iron
```
