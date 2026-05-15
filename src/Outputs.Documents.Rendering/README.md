# Outputs.Documents.Rendering

Generic rendering implementation.

This project wires together Razor component HTML rendering, template discovery, template registration, template selection, and document rendering orchestration. It does not know about DOCE, FSCD, or any specific document family.

## What Lives Here

- `Registration/`
  - `DocumentScanner`: scans assemblies for Razor components marked with `DocumentTemplateAttribute`.
  - `RenderingServiceCollectionExtensions`: DI extensions such as `AddRazorDocumentRendering()`, `WithDocumentsFromAssembly(...)`, and rule registration.
- `Rendering/`
  - `RazorComponentHtmlRenderer`: uses Blazor `HtmlRenderer` to render a component to HTML.
  - `DocumentRenderer`: selects a template, renders body/header/footer HTML, and calls `IPdfGenerator`.
- `Templates/`
  - `DocumentTemplateCatalog`: registry/catalog of descriptors.
  - `DocumentTemplateSelector`: evaluates selection rules and resolves the selected descriptor.

## Rules

- Do not reference origin projects.
- Do not hard-code document families, copybook names, or concrete template types.
- Do not implement PDF provider-specific logic here.
- Keep reflection in registration/scanning paths, not in render hot paths.
- Use `DocumentTemplateDescriptor` at runtime rather than reading attributes during render.

## Runtime Flow

```text
host registers assemblies
  -> DocumentScanner builds descriptors
  -> DocumentTemplateCatalog stores descriptors
  -> DocumentRenderer receives model + RenderSource
  -> DocumentTemplateSelector picks descriptor
  -> RazorComponentHtmlRenderer renders body/header/footer
  -> IPdfGenerator creates the PDF bytes
```
