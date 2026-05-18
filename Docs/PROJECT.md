# Project Overview

Outputs.Documents provides the infrastructure and project structure for document rendering in Outputs.

The system turns stable C# document contracts into Razor component templates, renders those templates to HTML, and optionally converts the HTML to PDF through provider-specific generators.

## Purpose

The project exists to keep document work split into clear ownership areas:

- stable platform contracts and rendering services;
- reusable document domain concepts;
- reusable Razor components and layouts;
- source-system contracts;
- source-system templates;
- development tools for samples, vector search, previews, and generated tests.

The goal is not only to render documents. The goal is to make document migration, template development, testing, and future repository splits predictable.

## Main Concepts

| Concept | Meaning |
|---|---|
| Document model | A C# contract implementing `IDocumentModel` |
| Origin contract | A source-system document contract such as DOCE or FSCD |
| Domain concept | A reusable business object such as `Entity`, `PostalAddress`, `Policy`, `Premium`, or `AtmPaymentReference` |
| Razor template | A Razor component marked with `DocumentTemplateAttribute` |
| Template descriptor | Precomputed metadata inferred from the template component and attribute |
| Template registry | Runtime catalog of descriptors |
| Template selector | Evaluates source/model rules and returns one descriptor |
| Razor component renderer | Low-level service that renders any Razor component to HTML |
| Document renderer | High-level renderer that selects a template, renders HTML, and calls a PDF generator |
| PDF generator | Provider implementation of `IPdfGenerator` |
| Sample | A small object that creates a model instance for tests and UI preview |

## Workspace Structure

```text
Core/
  src/
    Outputs.Documents.Abstractions/
    Outputs.Documents.Domain/
    Outputs.Documents.Components/
    Outputs.Documents.Rendering/
    Outputs.Documents.Rendering.Iron/
  tests/

DOCE/
  src/
    Outputs.Documents.DOCE.Contracts/
    Outputs.Documents.DOCE.Templates/
  tests/

FSCD/
  src/
    Outputs.Documents.FSCD.Contracts/
    Outputs.Documents.FSCD.Templates/
  tests/

Apps/
  src/
    Outputs.Documents.Dashboard/
    Outputs.Documents.Domain.VectorStore.McpServer/

Tools/
  src/
    Outputs.Documents.Domain.VectorStore/
    Outputs.Documents.SampleFinder/
    Outputs.Documents.TemplateTestGenerator/
  tests/

Docs/
data/
```

`Core/` is the stable platform. `DOCE/` and `FSCD/` are origin workspaces shaped like future repositories. `Apps/` contains runnable applications. `Tools/` contains reusable development helpers.

## Rendering Flow

```text
Host registration
  -> AddRazorDocumentRendering()
  -> WithDocumentsFromAssembly(...)
  -> WithSamplesFromAssembly(...)
  -> WithIronPdfGenerator()

Runtime render
  -> IDocumentRenderer.RenderAsync(model, source)
  -> IDocumentTemplateSelector.Select(model, source)
  -> IRazorComponentRenderer.RenderAsync(template, model)
  -> optional header/footer rendering
  -> IPdfGenerator.Generate(...)
```

The renderer must not know DOCE, FSCD, copybook names, or specific template classes.

## Direct Component Flow

Some tests and tools do not need the full document selector pipeline. They can render a known component directly:

```text
Template type + model
  -> IRazorComponentRenderer
  -> HTML
  -> IPdfGenerator
```

This is used by template integration tests and by UI preview experiments.

## Sample Flow

Origin contract projects contain sample classes beside the contract they construct.

```text
FSCD/src/Outputs.Documents.FSCD.Contracts/
  BGOW0044Contract/
    BGOW0044Contract.cs
    Samples/
      FS1040PremiumCancellationSample.cs
```

`Outputs.Documents.SampleFinder` scans assemblies for `IDocumentModelSample<TModel>` implementations and builds catalogs for tests and UI tools. Actual sample data does not live in the tool project.

## Source-Generated Template Tests

`Outputs.Documents.TemplateTestGenerator` is an analyzer/source generator used by provider integration test projects.

It discovers:

- template components marked with `DocumentTemplateAttribute`;
- model samples implementing `IDocumentModelSample<TModel>`;
- a fixture capable of rendering template/model pairs.

It emits xUnit theories that render each template with an empty model when possible and with every sample for the template model.

## Vector Store Flow

The domain vector store is storage-only. It does not create embeddings.

```text
Domain type
  -> Describe(Type)
  -> caller embeds descriptor text
  -> Upsert(modelName, domainType, embeddings)
  -> exact/vector/hybrid search
```

Domain semantic meaning comes from `DomainSearchAttribute` on types and properties.

## Important Boundaries

- Domain contracts must not depend on Razor.
- Origin contracts must not depend on templates, rendering, PDF providers, dashboard, or tools.
- Origin templates may depend on their origin contracts and shared components.
- Rendering must not hard-code origin-specific templates.
- PDF providers must stay behind `IPdfGenerator`.
- Development tools must not become production runtime dependencies unless explicitly promoted.

## Documentation Model

The root README is the front door. This file explains the system. Rules and decisions live in their own files:

- [RULES.md](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
- [DECISIONS.md](/Users/thepotato/Code/Outputs.Documents/Docs/DECISIONS.md)

If it is not written in a file, it will be forgotten.
