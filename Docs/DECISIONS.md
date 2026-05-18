# Decisions

This file records project decisions that should outlive chat history.

## Repository Shape

Decision: use top-level future-repository workspaces.

```text
Core/
Apps/
Tools/
DOCE/
FSCD/
Docs/
```

Reason: stable platform code should not churn with origin-specific copybook and template changes. Origin workspaces can later split into their own repositories with their `src/` and `tests/` shape intact.

## Core vs Origin

Decision: shared abstractions, domain concepts, components, rendering, and PDF provider abstractions live under `Core/src`; DOCE and FSCD contracts/templates live under their own origin folders.

Reason: origin APIs and templates will evolve independently and should not force every consumer to reference every origin contract.

## Template Identity

Decision: the Razor component type is the production template identity.

Reason: component types are strongly typed and debuggable. Production selection should not depend on string template keys or priority systems.

## Template Metadata

Decision: template metadata lives on Razor component classes through `DocumentTemplateAttribute`.

Reason: templates own rendering metadata. API models stay pure contracts.

## Model Type Inference

Decision: template discovery infers model type from the configured `[Parameter]` property when present.

Reason: the model type should not be duplicated in the attribute. The descriptor is built once during discovery and reused at runtime.

## No-Model Templates

Decision: templates without a model parameter are represented by `NoDocumentModel`.

Reason: diagnostic and calibration pages need to render through the normal template infrastructure without creating fake business models.

## Builder Registration

Decision: cross-project registration uses `RazorDocumentRenderingBuilder`.

Reason: it keeps domain-specific chains readable and lets rendering, samples, templates, and PDF providers extend the same registration flow without forcing all implementation projects to reference each other.

## Samples

Decision: sample authoring contracts live in `Outputs.Documents.Abstractions`, sample discovery lives in `Outputs.Documents.SampleFinder`, and sample data lives beside origin contracts.

Reason: origin contract projects must not depend on tools, but sample data is contract-shaped and should be easy for authors to find.

## Template Integration Tests

Decision: provider integration tests use a source generator to render every discovered template with an empty model when possible and every sample for the model.

Reason: the repeated test shape is stable across providers, and rendering all samples for the model catches contract/template mismatches beyond the happy path.

## Vector Store

Decision: the domain vector store is storage-only and receives embeddings from callers.

Reason: embedding providers vary by environment. The store owns database routing, exact/vector/hybrid search, and alignment checks, but not encoding.

## Documentation

Decision: root README stays small, while deeper project rules and architecture live in `Docs/`.

Reason: developers and agents need a fast front door plus stable files for detailed rules. If it is not in a file, it will be forgotten.
