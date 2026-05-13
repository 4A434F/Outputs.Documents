# Outputs.Documents

Outputs.Documents is a .NET 8 Razor document rendering system.

The solution is organized around a few strict ideas:

- API/domain models stay pure.
- Razor templates own render metadata.
- Template component type is the template identity.
- Template model type is inferred from the Razor `[Parameter]`, not duplicated in attributes.
- Template selection uses typed rules that return component `Type`, not string keys or priorities.
- Rendering code is generic and does not know DOCE, FSCD, or any future document family.
- Preview tooling is development-only and discovers templates/scenarios automatically.

This repository currently contains:

- Shared document contracts.
- Razor component to HTML rendering.
- Template scanning, registry, and selection.
- Document rendering to PDF through pluggable PDF generators.
- IronPDF and PdfSharp provider projects.
- Shared template/component project.
- FSCD template project.
- DOCE template project migrated from the earlier implementation.
- Unit tests and integration tests.
- A browser-based Razor document preview host.

## Solution Layout

```text
src/
  Outputs.Documents.Domain/
  Outputs.Documents.Abstractions/
  Outputs.Documents.Rendering/
  Outputs.Documents.Rendering.Iron/
  Outputs.Documents.Rendering.PdfSharp/
  Outputs.Documents.Preview.Abstractions/
  Outputs.Documents.Preview/
  Outputs.Documents.Templates/
  Outputs.Documents.Templates.FSCD/
  Outputs.Documents.Templates.Doce/

tests/
  Outputs.Documents.Rendering.Tests/
  Outputs.Documents.Rendering.Iron.Tests/
  Outputs.Documents.Rendering.PdfSharp.Tests/
  Outputs.Documents.Templates.Doce.Tests/
  Outputs.Documents.Templates.Doce.PdfSharp.IntegrationTests/
  Outputs.Documents.Templates.Doce.Iron.IntegrationTests/

tools/
  Outputs.Documents.PreviewHost/
```

## Project Responsibilities

### Outputs.Documents.Domain

Purpose: pure document model contracts and shared API-facing models.

Contains:

- `IDocumentModel`
- DOCE models such as `CoverPage`, `DeliveryNote`, `DoceCourtesyLetter`, `CttDispatchSheet`, `Divider`, `RegTicketPage`
- DOCE shared submodels such as `Header`, `Footer`, `Address`, `DocumentTraceId`, `GenericTable`, `SingleRegisterTicket`

Rules:

- Domain models must not reference Razor, rendering, PDF, DI, storage, preview, or template selection.
- Domain models must not have render attributes.
- Domain models should represent the document data contract only.
- Do not add template keys, template versions, metadata, storage IDs, or persistence concerns here.

### Outputs.Documents.Abstractions

Purpose: contracts shared by rendering, template projects, preview tooling, and hosts.

Contains rendering contracts:

- `IDocumentRenderer`
- `IPdfGenerator`
- `IRazorComponentRenderer`
- `RenderSource`

Contains template contracts and metadata:

- `DocumentTemplateAttribute`
- `DocumentLayoutAttribute`
- `DocumentTemplateDescriptor`
- `IDocumentTemplateRegistry`
- `IDocumentTemplateSelector`
- `IDocumentTemplateSelectionRule`
- `IDocumentTemplateSelectionRule<TModel>`
- `RazorDocumentRenderingBuilder`

Rules:

- Keep abstractions small and stable.
- Do not place concrete DOCE/FSCD logic here.
- Do not reference PDF provider packages here.
- Do not reference template projects here.
- Do not introduce string template keys for production selection. Preview keys are UI/dev metadata only.

### Outputs.Documents.Rendering

Purpose: core rendering implementation.

Contains:

- Razor component HTML renderer.
- Template scanner.
- Template registry/catalog.
- Template selector.
- Document renderer.
- DI registration extensions.

Important services/classes:

- `RazorComponentHtmlRenderer`
- `DocumentScanner`
- `DocumentTemplateCatalog`
- `DocumentTemplateSelector`
- `DocumentRenderer`
- `RenderingServiceCollectionExtensions`

Rules:

- Rendering must be document-family agnostic.
- Rendering must not hard-code DOCE or FSCD types.
- Rendering must not perform field-by-field model mapping.
- Rendering must not discover attributes during each render. Reflection happens during registration/scanning.
- Rendering receives a selected `DocumentTemplateDescriptor` and uses its precomputed metadata.
- Rendering depends on `IPdfGenerator`, but does not choose a provider.

### Outputs.Documents.Rendering.Iron

Purpose: IronPDF implementation of `IPdfGenerator`.

Contains:

- `IronPdfGenerator`
- `IronPdfGeneratorOptions`
- `WithIronPdfGenerator(...)`

Notes:

- IronPDF can produce real browser-quality PDF output.
- Running IronPDF may require a license depending on environment.
- Tests currently verify DI registration only, not full licensed PDF generation.

### Outputs.Documents.Rendering.PdfSharp

Purpose: lightweight PdfSharp implementation of `IPdfGenerator`.

Contains:

- `PdfSharpPdfGenerator`
- `PdfSharpPdfGeneratorOptions`
- `WithPdfSharpPdfGenerator(...)`

Notes:

- This provider is intentionally simple.
- It strips HTML to text and writes PDF bytes.
- It is useful for smoke/integration tests without an IronPDF license.
- It is not intended to be a high-fidelity HTML/CSS renderer.

### Outputs.Documents.Templates

Purpose: shared reusable Razor components, layouts, styles, and template utilities.

Current contents:

- DOCE reusable components under `Doce/Components`
- DOCE layouts under `Doce/Layouts`
- DOCE template configuration helpers such as `StaticFilePaths`

Rules:

- Put reusable Razor components here when more than one concrete template assembly can use them.
- Put shared document layout components here.
- Put shared template-only configuration here if it is not part of API/domain models.
- Do not put concrete document templates here unless they are truly shared templates.
- Do not put document models here if they are API/domain contracts.

### Outputs.Documents.Templates.FSCD

Purpose: FSCD-specific document templates, FSCD sample models, selection rules, and preview scenarios.

Contains:

- FSCD Razor templates under per-template folders.
- FSCD sample document models.
- FSCD selection rules.
- `Templates/FscdDocument/FscdDocumentPreviewScenarios.cs`
- `Templates/CourtesyLetter/CourtesyLetterPreviewScenarios.cs`

Rules:

- FSCD-specific template components go here.
- FSCD-specific rules go here.
- FSCD preview scenario providers live beside the template they preview.
- Do not add FSCD-specific DI extension methods when generic assembly scanning is enough.
- If a model is a real API/domain contract, move it to `Outputs.Documents.Domain`.
- If a component becomes reusable by another template family, move it to `Outputs.Documents.Templates`.

### Outputs.Documents.Templates.Doce

Purpose: DOCE-specific concrete templates, rules, assets, and preview scenarios.

Contains:

- `Templates/CourtesyLetter/CourtesyLetterTemplate.razor`
- `Templates/CourtesyLetter/CourtesyLetterPreviewScenarios.cs`
- `Templates/CoverPage/CoverPageTemplate.razor`
- `Templates/CoverPage/CoverPagePreviewScenarios.cs`
- `Templates/CTTDispatchSheet/CTTDispatchSheetTemplate.razor`
- `Templates/CTTDispatchSheet/CTTDispatchSheetPreviewScenarios.cs`
- `Templates/DeliveryNote/DeliveryNoteTemplate.razor`
- `Templates/DeliveryNote/DeliveryNotePreviewScenarios.cs`
- `Templates/Divider/DividerTemplate.razor`
- `Templates/Divider/DividerPreviewScenarios.cs`
- `Templates/RegTicketPage/RegTicketPageTemplate.razor`
- `Templates/RegTicketPage/RegTicketPagePreviewScenarios.cs`
- DOCE static assets in `wwwroot`

Rules:

- Concrete DOCE templates go here.
- Each concrete template gets its own folder under `Templates/`.
- A template folder contains the Razor template and any preview scenario providers for that template.
- Do not add DOCE-specific DI extension methods when generic assembly scanning is enough.
- Register DOCE templates with `.WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)`.
- Register DOCE preview scenarios with `.WithDocumentPreviewAssembly(typeof(CourtesyLetterTemplate).Assembly)`.
- DOCE reusable components belong in `Outputs.Documents.Templates`.
- DOCE domain models belong in `Outputs.Documents.Domain`.

### Outputs.Documents.Preview.Abstractions

Purpose: contracts for development-time preview tooling.

Contains:

- `DocumentPreviewScenario`
- `IDocumentPreviewScenarioProvider`
- `IDocumentPreviewCatalog`
- `RazorDocumentPreviewBuilder`

Rules:

- Preview contracts may reference rendering abstractions, but should not reference concrete template projects.
- Scenario providers live with template projects, not inside the preview host.
- Keep this project suitable for template projects to reference.

### Outputs.Documents.Preview

Purpose: preview discovery, preview catalog, preview HTML rendering, and DI registration.

Contains:

- `DocumentPreviewDiscovery`
- `DocumentPreviewCatalog`
- `DocumentPreviewHtmlRenderer`
- `IDocumentPreviewHtmlRenderer`
- `DocumentPreviewServiceCollectionExtensions`

Rules:

- Preview discovery must scan assemblies automatically.
- Preview catalog must validate duplicate template keys.
- Preview catalog must validate duplicate scenario keys per model type.
- Preview catalog must not require every template to have a scenario.
- Preview catalog must not throw when a scenario exists without a template.
- Preview rendering must reuse `IRazorComponentRenderer`.
- Preview must not own production template selection rules.

### Outputs.Documents.PreviewHost

Purpose: development-only Blazor/ASP.NET Core app for browser previews.

Contains:

- Generated template index at `/preview`
- Template preview page at `/preview/{templateKey}`
- Scenario preview page at `/preview/{templateKey}/{scenarioKey}`
- Raw HTML route at `/preview/{templateKey}/{scenarioKey}/html`
- Component render mode
- Production HTML render mode
- Raw HTML mode
- Metadata mode

Rules:

- The host must not have manual navigation per document.
- Navigation comes from `IDocumentPreviewCatalog.Templates`.
- Scenarios come from `IDocumentPreviewCatalog.GetScenariosForTemplate(...)`.
- The host registers template assemblies and preview assemblies.
- The host is not production code.

Run it with:

```bash
dotnet run --project tools/Outputs.Documents.PreviewHost/Outputs.Documents.PreviewHost.csproj
```

Then open:

```text
http://localhost:5179/preview
```

If no URL is specified, ASP.NET Core may choose a different port. To force the current local convention:

```bash
dotnet run --project tools/Outputs.Documents.PreviewHost/Outputs.Documents.PreviewHost.csproj --urls http://localhost:5179
```

## Core Concepts

### Document Model

Every renderable root model implements:

```csharp
public interface IDocumentModel
{
}
```

The marker interface lives in `Outputs.Documents.Domain`.

The model is the root data contract passed into rendering:

```csharp
await renderer.RenderAsync(model);
await renderer.RenderAsync(model, source);
```

### RenderSource

`RenderSource` describes request context:

```csharp
public sealed record RenderSource(
    string? Name = null,
    string? Operation = null,
    bool IsPreview = false,
    bool IsReprint = false,
    bool IsBatch = false,
    IReadOnlyDictionary<string, object?>? Metadata = null);
```

It is used by selection rules.

Examples:

- preview render
- reprint
- batch run
- operation-specific template choice

Rules:

- Keep `RenderSource` small.
- Do not turn it into a large request object.
- Do not put model data in `RenderSource`.

### DocumentTemplateAttribute

Placed on Razor component classes:

```razor
@attribute [DocumentTemplate(
    isDefault: true,
    Key = "doce-courtesy-letter",
    Name = "Courtesy Letter",
    Group = "DOCE")]
```

Properties:

- `IsDefault`
- `ModelParameterName`
- `Key`
- `Name`
- `Group`

Important decision:

- The attribute does not declare `ModelType`.
- The scanner infers `ModelType` from the Razor component parameter.

Example:

```razor
@code {
    [Parameter]
    public DoceCourtesyLetter Model { get; set; } = default!;
}
```

This infers:

- `ModelType = typeof(DoceCourtesyLetter)`
- `ModelParameterName = "Model"`
- `BodyTemplateType = typeof(CourtesyLetterTemplate)`

Rules:

- Every document template must have `[DocumentTemplate]`.
- The configured model parameter must exist.
- The model parameter must be public.
- The model parameter must be marked `[Parameter]`.
- The model parameter type must not be `object`.
- Keep the default parameter name as `Model` unless a template has a strong reason not to.

### DocumentLayoutAttribute

Placed on Razor component classes when the document has header/footer components or custom page size:

```razor
@attribute [DocumentLayout(
    headerTemplate: typeof(HeaderComponent),
    footerTemplate: typeof(FooterComponent),
    headerPropertyName: nameof(DoceCourtesyLetter.Header),
    footerPropertyName: nameof(DoceCourtesyLetter.Footer))]
```

Supported metadata:

- `HeaderTemplateType`
- `FooterTemplateType`
- `HeaderPropertyName`
- `FooterPropertyName`
- `WidthCm`
- `HeightCm`

Rules:

- Header/footer source properties are resolved from the root model.
- If no header/footer property is provided, the root model is used.
- If the resolved header/footer source is null, that partial is skipped.
- Do not map individual fields manually into components.

### DocumentTemplateDescriptor

Runtime descriptor produced during scanning.

Contains:

- model type
- body template component type
- default flag
- header/footer template types
- header/footer source property names
- optional page size
- model parameter name
- preview key/name/group
- precomputed header/footer property accessors

Why it exists:

- Reflection is done at registration/startup.
- Runtime rendering uses descriptors and compiled accessors.
- The hot path should be dictionary/type lookups and component rendering, not attribute inspection.

### Template Identity

Production template identity is the template component type.

Rules:

- Selection rules return `typeof(SomeTemplateComponent)`.
- Production selection does not use string keys.
- There is no priority system.
- There is no generic string/expression rule engine.
- Multiple rules may return the same component type.
- Multiple different component types for the same render request is an error.

Preview has URL-safe keys for navigation. Those keys are development/UI metadata and must not become production selection identity.

## Rendering Pipeline

### Registration

Typical host registration:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithPdfSharpPdfGenerator();
```

Provider-specific examples:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithIronPdfGenerator();
```

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithPdfSharpPdfGenerator();
```

`AddRazorDocumentRendering()` registers:

- `IRazorComponentRenderer`
- `HtmlRenderer`
- `IDocumentTemplateRegistry`
- `IDocumentTemplateSelector`

`WithPdfGenerator(...)` registers:

- `IPdfGenerator`
- `IDocumentRenderer`

Important decision:

- `IDocumentRenderer` is not registered by the base rendering method unless a PDF generator is provided.
- This avoids a broken renderer registration with no `IPdfGenerator`.

### Template Scanning

`DocumentScanner.ScanTemplates(assembly)`:

1. Scans non-abstract `IComponent` types.
2. Finds `[DocumentTemplate]`.
3. Resolves `ModelParameterName`, defaulting to `"Model"`.
4. Finds the public model property.
5. Verifies `[Parameter]`.
6. Infers model type from the property.
7. Reads optional `[DocumentLayout]`.
8. Validates header/footer component types.
9. Compiles header/footer property accessors.
10. Builds `DocumentTemplateDescriptor`.

`DocumentScanner.ScanSelectionRules(assembly)`:

1. Scans non-abstract classes.
2. Finds types assignable to `IDocumentTemplateSelectionRule`.
3. Registers them in DI.

### Registry

The registry stores descriptors by:

- template component type
- model type
- model default

Validation:

- Duplicate template component types throw.
- More than one default template for the same model type throws.
- Unknown template type throws with a clear message.
- Unknown model type throws with a clear message.
- If one template exists for a model, it can act as default.
- If multiple templates exist and none is default, asking for default throws.

### Selection Rules

Base interface:

```csharp
public interface IDocumentTemplateSelectionRule
{
    Type ModelType { get; }

    Type? SelectTemplate(object model, RenderSource source);
}
```

Typed helper:

```csharp
public interface IDocumentTemplateSelectionRule<TModel>
    : IDocumentTemplateSelectionRule
{
    Type? SelectTemplate(TModel model, RenderSource source);
}
```

The typed interface supplies explicit implementation:

- `ModelType => typeof(TModel)`
- safely casts the object model
- calls the typed method

Why it exists:

- Rules can be implemented with real model types.
- The selector can evaluate all rules through one non-generic interface.
- Rules stay debuggable and type-safe.

Example:

```csharp
public sealed class CourtesyLetterPreviewTemplateRule
    : IDocumentTemplateSelectionRule<CourtesyLetter>
{
    public Type? SelectTemplate(CourtesyLetter model, RenderSource source)
    {
        return source.IsPreview
            ? typeof(CourtesyLetterPreviewTemplate)
            : null;
    }
}
```

### Template Selection Flow

`DocumentTemplateSelector.Select(model, source)`:

1. Gets the runtime model type.
2. Finds rules matching that model type.
3. Evaluates every rule.
4. Removes null results.
5. Groups by distinct returned template type.
6. If no rule returns a template, returns registry default.
7. If one distinct template type is returned, resolves descriptor.
8. If multiple different template types are returned, throws a clear exception.
9. Verifies returned template is registered.
10. Verifies returned template belongs to the model type.

Rules:

- Multiple rules returning the same template type is allowed.
- Multiple rules returning different template types is not allowed.
- Rules do not have priority.
- Rules do not expose `IsMatch`.

### Document Rendering Flow

`DocumentRenderer.RenderAsync(model, source)`:

1. Validates model.
2. Normalizes `source` to `RenderSource.Empty` if null.
3. Uses `IDocumentTemplateSelector` to get a descriptor.
4. Renders body component with the root model:

   ```csharp
   components.RenderAsync(
       descriptor.BodyTemplateType,
       model,
       descriptor.ModelParameterName)
   ```

5. Resolves header source model:

   - If no header template, skip.
   - If no header property name, use root model.
   - If header property name exists, use precomputed accessor.
   - If resolved value is null, skip.

6. Renders header component with the resolved model.
7. Resolves/renders footer the same way.
8. Calls `IPdfGenerator.GenerateAsync(...)`.

Important:

- Body receives the full root model.
- Header/footer receive configured submodels.
- No field-by-field mapping happens.
- Attributes are not read during render.

### Razor Component HTML Rendering Flow

`RazorComponentHtmlRenderer`:

1. Validates component type implements `IComponent`.
2. Validates model is non-null for model overloads.
3. Creates an async DI scope per render.
4. Resolves `HtmlRenderer`.
5. Converts parameter dictionary to `ParameterView`.
6. Uses `renderer.Dispatcher.InvokeAsync(...)`.
7. Calls `RenderComponentAsync(componentType, view)`.
8. Returns `rendered.ToHtmlString()`.

Why this is separate:

- It is the low-level HTML rendering primitive.
- Document rendering uses it.
- Preview production HTML mode uses it.
- Tests can exercise it independently.

## PDF Generation

`IPdfGenerator` is the provider boundary:

```csharp
Task<byte[]> GenerateAsync(
    string bodyHtml,
    string? headerHtml = null,
    string? footerHtml = null,
    double? widthCm = null,
    double? heightCm = null,
    CancellationToken cancellationToken = default);
```

Rules:

- Core rendering never references IronPDF or PdfSharp packages.
- PDF provider projects register themselves through builder extensions.
- A provider should validate non-empty body HTML.
- Provider-specific options stay in the provider project.

## Preview Tool

### Preview Registration

Preview host registration:

```csharp
builder.Services
    .AddRazorDocumentPreview()
    .WithDocumentPreviewAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithDocumentPreviewAssembly(typeof(FscdDocumentTemplate).Assembly);
```

`WithDocumentPreviewAssembly(...)` scans one assembly for:

- document templates
- preview scenario providers

This supports the workflow:

1. Create Razor template.
2. Add `[DocumentTemplate]`.
3. Add preview scenarios in the template assembly.
4. Run PreviewHost.
5. Template appears automatically.

### Preview Scenario

```csharp
public sealed record DocumentPreviewScenario(
    string Key,
    string Name,
    Type ModelType,
    object Model);
```

Rules:

- Scenario keys must be stable and URL-safe.
- Scenario keys only need to be unique per model type.
- Scenario models should represent real layout cases.
- Avoid random fake data that does not test layout behavior.
- Put scenarios in the template project they support.

Example:

```csharp
public sealed class CourtesyLetterPreviewScenarios : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new(
            "standard",
            "Standard courtesy letter",
            typeof(DoceCourtesyLetter),
            Samples.CourtesyLetter());
    }
}
```

### Preview Discovery

`DocumentPreviewDiscovery.DiscoverTemplates(assembly)`:

- Uses the same inference rule as rendering.
- Scans `[DocumentTemplate]`.
- Infers model type from `[Parameter]`.
- Builds `DocumentTemplateDescriptor`.

`DocumentPreviewDiscovery.DiscoverScenarioProviders(assembly)`:

- Finds non-abstract classes implementing `IDocumentPreviewScenarioProvider`.
- Registers them in DI.

### Preview Catalog

`DocumentPreviewCatalog` joins:

- descriptors
- scenario providers

It exposes:

- all templates
- all scenarios
- find template by key
- get scenarios for template
- find scenario by key

Validation:

- Duplicate template preview keys throw.
- Duplicate scenario keys for the same model type throw.
- Template without scenario is allowed.
- Scenario without template is allowed.

### Preview Host UI

Routes:

```text
/preview
/preview/{templateKey}
/preview/{templateKey}/{scenarioKey}
/preview/{templateKey}/{scenarioKey}/html
```

Index page:

- Shows all discovered templates.
- Groups by descriptor `Group`.
- Orders by group/name.
- Links to first available scenario.

Template page:

- Left sidebar generated from catalog.
- Toolbar with template name, scenario selector, render mode selector, refresh, raw HTML.
- Component mode with `DynamicComponent`.
- Production HTML mode with iframe `srcdoc`.
- Raw HTML mode with generated HTML text.
- Metadata mode with descriptor/scenario details.

Render modes:

- Component: fastest visual loop, uses Blazor component rendering directly.
- Production HTML: uses `DocumentPreviewHtmlRenderer` and `IRazorComponentRenderer`.
- Raw HTML: shows exact generated HTML.
- Metadata: shows template/scenario info.

Current known note:

- Some migrated DOCE components inline a large font data URL that can create browser console noise in preview.
- This is a template asset/CSS cleanup concern, not a preview catalog/navigation issue.

## Testing

### Unit Tests

`Outputs.Documents.Rendering.Tests` covers:

- DI registration
- template scanning
- template registry behavior
- template selector behavior
- document renderer body/header/footer flow
- Razor component HTML renderer

### Provider Tests

`Outputs.Documents.Rendering.Iron.Tests`:

- verifies Iron provider DI registration.

`Outputs.Documents.Rendering.PdfSharp.Tests`:

- verifies PdfSharp provider DI registration.
- verifies simple PDF byte generation.

### Template Tests

`Outputs.Documents.Templates.Doce.Tests`:

- verifies DOCE template registration/scanning behavior.

### Integration Tests

`Outputs.Documents.Templates.Doce.PdfSharp.IntegrationTests`:

- renders DOCE document models through DI.
- generates real PDF bytes using PdfSharp.
- saves PDF files under test output for inspection.

`Outputs.Documents.Templates.Doce.Iron.IntegrationTests`:

- renders the same DOCE document models through DI.
- generates real PDF bytes using IronPDF when an IronPDF license is configured.
- reads the license from `IronPdf:LicenseKey` user-secrets or `IRONPDF_LICENSE_KEY`.
- saves Iron-generated PDF files under test output for inspection.

The two integration projects intentionally share the same document sample builders. This keeps the provider coverage aligned while still allowing each PDF library to have its own fixture, dependencies, and output files.

Current integration scenarios in both provider projects:

- cover page with destination
- cover page summary only
- CTT dispatch sheet
- divider
- delivery note
- courtesy letter
- registered ticket page

Run everything:

```bash
dotnet test Outputs.Documents.sln
```

## Adding a New Document Family

Example family: `Outputs.Documents.Templates.Cancellation`.

1. Add or identify domain models.

If the model is part of the public/API contract, place it in:

```text
src/Outputs.Documents.Domain/
```

Model must implement:

```csharp
IDocumentModel
```

2. Create a Razor class library:

```text
src/Outputs.Documents.Templates.Cancellation/
```

3. Add templates:

```text
Templates/CancellationLetterTemplate.razor
```

4. Mark templates:

```razor
@attribute [DocumentTemplate(
    isDefault: true,
    Key = "cancellation-letter",
    Name = "Cancellation Letter",
    Group = "Cancellation")]

@code {
    [Parameter]
    public CancellationLetterModel Model { get; set; } = default!;
}
```

5. Add layout metadata if needed:

```razor
@attribute [DocumentLayout(
    headerTemplate: typeof(HeaderComponent),
    footerTemplate: typeof/FooterComponent),
    headerPropertyName: nameof(CancellationLetterModel.Header),
    footerPropertyName: nameof(CancellationLetterModel.Footer))]
```

6. Add selection rules only if default selection is not enough:

```csharp
public sealed class CancellationPreviewRule
    : IDocumentTemplateSelectionRule<CancellationLetterModel>
{
    public Type? SelectTemplate(CancellationLetterModel model, RenderSource source)
    {
        return source.IsPreview ? typeof(CancellationLetterPreviewTemplate) : null;
    }
}
```

7. Add preview scenarios:

```csharp
public sealed class CancellationPreviewScenarios
    : IDocumentPreviewScenarioProvider
{
    public IEnumerable<DocumentPreviewScenario> GetScenarios()
    {
        yield return new(
            "default",
            "Default",
            typeof(CancellationLetterModel),
            CancellationSamples.Default());
    }
}
```

8. Add registration extension:

```csharp
public static class CancellationTemplateServiceCollectionExtensions
{
    public static RazorDocumentRenderingBuilder WithCancellationTemplates(
        this RazorDocumentRenderingBuilder builder)
    {
        return builder.WithDocumentsFromAssembly(typeof(CancellationLetterTemplate).Assembly);
    }
}
```

9. Register in host:

```csharp
services
    .AddRazorDocumentRendering()
    .WithCancellationTemplates()
    .WithPdfSharpPdfGenerator();
```

10. Register in preview host:

```csharp
builder.Services
    .AddRazorDocumentPreview()
    .WithDocumentPreviewAssembly(typeof(CancellationLetterTemplate).Assembly);
```

## What Goes Where

### Put in Domain

- API document models.
- Shared data contracts.
- Model subobjects such as address/header/footer when they are part of the document contract.
- `IDocumentModel` implementations.

Do not put:

- Razor components.
- Rendering attributes.
- PDF options.
- DI extensions.
- Preview scenarios.

### Put in Abstractions

- Interfaces.
- Attributes.
- Descriptor types.
- Builder types shared by provider/template projects.

Do not put:

- Concrete scanner implementations.
- Concrete registries/selectors.
- Provider implementations.
- Template-family-specific logic.

### Put in Rendering

- Rendering implementation.
- Scanning implementation.
- Registry/selector implementation.
- Core DI extensions.
- Low-level Razor component HTML renderer.

Do not put:

- DOCE/FSCD templates.
- PDF provider packages.
- Domain-specific selection logic.

### Put in Rendering Provider Projects

- `IPdfGenerator` implementation.
- Provider options.
- Provider registration extension.
- Provider-specific tests.

Do not put:

- Template scanning.
- Template selection rules.
- Domain models.

### Put in Templates

- Reusable Razor components.
- Shared layouts.
- Shared CSS/assets used by templates.
- Template-only configuration helpers.

Do not put:

- Concrete document-family templates unless they are truly shared.
- API/domain models.

### Put in Template Family Projects

- Concrete templates.
- Family-specific preview scenario providers.
- Family-specific template registration.
- Family-specific selection rules.
- Family-specific assets.

Do not put:

- Shared reusable components that other families use.
- Core rendering logic.

### Put in Preview.Abstractions

- Preview scenario contracts.
- Preview catalog contract.
- Preview builder.

Do not put:

- Blazor UI.
- Template-family-specific scenario data.

### Put in Preview

- Preview scanner.
- Preview catalog.
- Preview HTML renderer.
- Preview DI extensions.

Do not put:

- Concrete sample scenarios.
- Manual template navigation.

### Put in PreviewHost

- Development-only UI.
- Assembly registration for local preview.
- Static preview host CSS.

Do not put:

- Production rendering rules.
- Scenario data.
- Manual template pages per document.

## Design Decisions Made So Far

### No RenderRequest or RenderResult

The public render API remains small:

```csharp
Task<byte[]> RenderAsync<TModel>(TModel model);
Task<byte[]> RenderAsync<TModel>(TModel model, RenderSource source);
```

Reason:

- Avoid over-modeling too early.
- Keep the first renderer focused.
- Add richer request/result objects only when real requirements appear.

### Template Class Type Is Production Identity

Rules return component `Type`.

Reason:

- Avoid string-key drift.
- Refactoring-safe enough for code.
- Easy to debug.
- No priority or ranking system needed.

### Model Type Is Inferred

`DocumentTemplateAttribute` does not declare model type.

Reason:

- Avoid duplicate truth.
- Razor component parameter is the real contract.
- Scanner can validate startup errors clearly.

### Builder Registration Is Intentional

Rendering:

```csharp
services.AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithPdfSharpPdfGenerator();
```

Preview:

```csharp
services.AddRazorDocumentPreview()
    .WithDocumentPreviewAssembly(...);
```

Reason:

- Keeps domain-specific registration chained.
- Makes startup readable.
- Prevents unrelated service registration from being mixed into the middle of document setup.

### Preview Is Separate From Production

PreviewHost lives under `tools/`.

Reason:

- It is a developer tool.
- It should not affect production hosts.
- It can reference template assemblies and sample data freely.

### Integration Tests Are Provider-Specific

Reason:

- PdfSharp integration tests provide a license-free end-to-end smoke path for document rendering.
- IronPDF integration tests verify the production-style Iron provider path when a license is available.
- Keeping one integration project per provider avoids conditional provider setup inside a single fixture.
- Both provider projects render the same DOCE scenarios, so differences are caused by the PDF implementation rather than sample data.

Iron integration behavior:

- If `IronPdf:LicenseKey` or `IRONPDF_LICENSE_KEY` is configured, the tests generate real PDFs.
- If no license is configured, the Iron integration tests return without rendering so unlicensed environments stay buildable.
- The repository must not contain committed license keys; use user-secrets or environment variables.

## Current Commands

Build:

```bash
dotnet build Outputs.Documents.sln
```

Test:

```bash
dotnet test Outputs.Documents.sln
```

Run preview:

```bash
dotnet run --project tools/Outputs.Documents.PreviewHost/Outputs.Documents.PreviewHost.csproj --urls http://localhost:5179
```

Open:

```text
http://localhost:5179/preview
```

## Current Status

Implemented:

- Domain marker and DOCE domain models.
- Rendering abstractions.
- Razor component HTML renderer.
- Template scanner.
- Template registry/catalog.
- Template selector.
- Document renderer.
- IronPDF provider.
- PdfSharp provider.
- Shared template project.
- FSCD templates, rules, and preview scenarios.
- DOCE templates, assets, and preview scenarios.
- DOCE PdfSharp integration tests that generate PDFs.
- DOCE IronPDF integration tests that generate PDFs when licensed.
- Preview abstractions.
- Preview catalog/discovery.
- PreviewHost with automatic navigation and raw HTML.

Not implemented yet:

- High-fidelity shared CSS injection strategy between preview and production.
- HTML export/download file action.
- PDF export from PreviewHost.
- Visual regression testing.
- Screenshot comparison.
- Editable scenario models in UI.
- Database/sample data storage.
