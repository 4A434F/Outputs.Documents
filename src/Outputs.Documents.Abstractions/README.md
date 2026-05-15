# Outputs.Documents.Abstractions

Stable contracts for the document rendering stack.

This project defines the small public surface that other projects build against. It should stay free of concrete DOCE, FSCD, Razor component implementations, PDF provider implementations, storage, and dashboard concerns.

## Folder Structure

```text
Outputs.Documents.Abstractions/
  Models/
  Registration/
  Rendering/
  Templates/
```

Generated folders such as `bin/` and `obj/` are build output and are not part of the source structure.

## What Lives Where

### Models

Shared document model contracts.

Files:

- `IDocumentModel`: marker contract for renderable document models.
- `NoDocumentModel`: shared empty model for templates that intentionally do not receive document data, such as diagnostics and calibration pages.

Rules:

- Keep this folder very small.
- Put only model-level contracts that every origin contract can safely reference.
- Do not put DOCE, FSCD, copybook, template, or rendering implementation concepts here.

### Rendering

Rendering contracts and request context.

Files:

- `IDocumentRenderer`: high-level contract for rendering a document model.
- `IRazorComponentRenderer`: low-level Razor component to HTML rendering contract.
- `IPdfGenerator`: HTML to PDF provider contract.
- `RenderSource`: request context used by template selection rules.

Rules:

- Put contracts here when they describe a rendering capability.
- Keep provider-specific behavior out of this folder. IronPDF, PdfSharp, browser engines, and other concrete implementations belong in implementation projects.
- Do not put template discovery or template registry storage here unless the type is part of the public rendering contract.

### Templates

Template metadata, descriptors, registry contracts, and selection rule contracts.

Files:

- `DocumentTemplateAttribute`: metadata placed on Razor component classes.
- `DocumentTemplateDescriptor`: precomputed template metadata consumed at runtime.
- `IDocumentTemplateRegistry`: runtime catalog of discovered templates.
- `IDocumentTemplateSelector`: selector that resolves model/source to one descriptor.
- `IDocumentTemplateSelectionRule`: untyped template selection rule contract.
- `IDocumentTemplateSelectionRule<TModel>`: typed helper for model-specific selection rules.

Rules:

- Put types here when they describe how templates are declared, registered, found, or selected.
- Do not put Razor component files here.
- Do not put scanner implementations here. Discovery logic belongs in `Outputs.Documents.Rendering`.
- Do not add string template keys for production selection. The template component type is the production identity.

### Registration

Cross-project registration builder contracts.

Files:

- `RazorDocumentRenderingBuilder`: fluent registration builder shared by rendering, template, sample, and provider registration extensions.

Rules:

- Put only registration coordination types here when multiple projects need to extend the same fluent chain.
- Keep actual service registration logic in the project that owns the implementation.
- Use this folder to keep the registration API consistent without making implementation projects depend on each other.

## Rules

- Do not reference origin projects.
- Do not reference concrete rendering providers such as IronPDF.
- Do not place Razor components here.
- Do not place domain data structures here unless they are true cross-cutting rendering abstractions.
- Keep interfaces small and stable.

## Dependency Direction

Allowed:

```text
Rendering -> Abstractions
Templates -> Abstractions
Origin Contracts -> Abstractions
Origin Templates -> Abstractions
Apps -> Abstractions
```

Avoid:

```text
Abstractions -> Rendering
Abstractions -> Origin Contracts
Abstractions -> Apps
```
