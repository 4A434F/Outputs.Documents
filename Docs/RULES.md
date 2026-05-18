# Project Rules

This file contains rules that agents and developers must preserve when changing Outputs.Documents.

If a rule is important, it belongs here or in a local project README. Chat history is not a source of truth.

## Documentation Rules

- `README.md` is the repo front door.
- `Docs/PROJECT.md` explains the system.
- `Docs/RULES.md` stores rules and boundaries.
- `Docs/DECISIONS.md` stores design decisions and proposals.
- Local project READMEs are allowed when opening that folder without context would be confusing.
- Update documentation when behavior, ownership, registration flow, or folder structure changes.

## Dependency Rules

- `Core/src` projects must not reference origin workspaces.
- Origin contract projects must not reference templates, rendering implementations, PDF providers, tools, or apps.
- Origin template projects may reference their origin contracts and shared core components.
- Apps may compose core, origin, and tool projects.
- Tools may reference abstractions/core as needed, but production code should not depend on tools unless that dependency is intentional.

## Contract Rules

- API/domain models remain pure C# contracts.
- Contracts implement `IDocumentModel` when renderable.
- Contracts do not contain Razor metadata.
- Contracts do not contain PDF, storage, rendering, or UI logic.
- Origin-specific copybook contracts live in the origin workspace.
- Reusable domain concepts live in `Outputs.Documents.Domain`.
- Searchable domain concepts should use `DomainSearchAttribute` on types and useful properties.
- Copybook aliases should be captured in domain/search annotations when they improve matching.

## Template Rules

- Razor templates own render metadata through `DocumentTemplateAttribute`.
- The template component type is the production template identity.
- Do not introduce string template keys for production selection.
- Do not introduce priority-based selection.
- Do not hard-code origin-specific template types in the renderer.
- Body templates receive the full model through the configured model parameter.
- Templates with no model parameter are mapped to `NoDocumentModel`.
- Concrete origin templates live in the origin template project.
- Shared layouts and reusable fragments live in `Outputs.Documents.Components`.

## Rendering Rules

- Reflection belongs in discovery/registration, not in the render hot path.
- Runtime rendering consumes `DocumentTemplateDescriptor`.
- Template selection must return zero or one distinct selected template type.
- Multiple rules returning the same template type are allowed.
- Multiple different selected template types must throw a clear exception.
- If no rule selects a template, the default template is used.
- If a model has multiple templates and none is default, default lookup must throw.
- `IRazorComponentRenderer` is the low-level Razor-to-HTML service.
- `IDocumentRenderer` is the high-level model/source-to-PDF orchestration service.
- `IPdfGenerator` implementations live in provider projects such as `Outputs.Documents.Rendering.Iron`.

## Component Rules

- Layouts set base page behavior, font family, font size, line height, and absolute page positioning.
- Components may override typography only when the document standard requires it, such as postal address blocks.
- Components should stay reusable and origin-neutral.
- Origin-specific wording belongs in origin templates, not in shared components.
- Printable calibration documents must stay renderable through the same rendering stack used by templates.

## Sample Rules

- The sample authoring interface lives in `Outputs.Documents.Abstractions`.
- Sample discovery and catalogs live in `Outputs.Documents.SampleFinder`.
- Actual sample data lives beside the contract it constructs.
- Samples validate model shape and template behavior; they are not production domain data.
- Generated template integration tests should render all samples for the model, not only happy-path samples.

## Test Rules

- Test project names end with the test type, such as `UnitTests` or `IntegrationTests`.
- Provider PDF tests can use direct component rendering when selector behavior is not under test.
- Full pipeline tests should be reserved for registration, selection, and orchestration behavior.
- Generated tests should remove boilerplate but keep the fixture explicit.

## Vector Store Rules

- The vector store stores embeddings; it does not create embeddings.
- Registration starts from a C# domain type and its descriptors.
- Callers embed descriptor text externally.
- Upsert re-reads descriptors from the domain type to keep metadata aligned with source code.
- Alignment uses the fixed prompt set owned by the vector store project.
- Exact search and vector search are separate capabilities.

## Development Workflow

1. Read the relevant local README and docs before changing behavior.
2. Make the smallest change that fits the existing architecture.
3. Run focused tests first.
4. Run broader tests when crossing project boundaries.
5. Update docs when the change affects rules, behavior, structure, or usage.
