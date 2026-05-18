# Outputs.Documents.Components

Shared Razor components, layouts, and printable utility pages for document templates.

This project contains reusable presentation pieces used by origin-specific templates. It does not contain DOCE or FSCD contracts, and it does not own concrete origin templates.

## Status

- Maturity: core component library
- Runtime: .NET 8 Razor class library
- Output: reusable Razor components and static assets
- Stability expectation: shared visual behavior should change carefully because it affects multiple origins

## Fast Start

Reference this project from an origin template project.

Build from the repository root:

```bash
dotnet build Core/src/Outputs.Documents.Components/Outputs.Documents.Components.csproj
```

Run the component integration test:

```bash
dotnet test Core/tests/Outputs.Documents.Components.IntegrationTests/Outputs.Documents.Components.IntegrationTests.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `Branding/` | Shared header/footer style components |
| `Calibration/` | Printable calibration templates |
| `Configuration/` | Static file path helpers and environment flags |
| `Diagnostics/` | Trace id and test overlay components |
| `Expedition/` | Expedition and registration-ticket components |
| `Formatting/` | Formatting helpers such as money/date display helpers |
| `Layouts/` | A4 and letter layout wrappers |
| `Letters/` | Letter-specific structural components such as subject and date |
| `Locations/` | Postal address rendering components |
| `Payments/` | Payment components such as Multibanco references |
| `Signatures/` | Signature block components |
| `Tables/` | Generic and simple value table components |
| `Tables/<Component>/Styles/` | Per-style render fragments for components with selectable styles |

## Architecture Summary

Components provide reusable visual building blocks. Origin templates compose them with origin contracts.

```text
Origin template
  -> shared layout
  -> shared fragments
  -> origin-specific wording and data binding
```

The layout should set page-level defaults such as page size, base font, line height, trace positioning, and absolute page behavior. Leaf components may override style only when a document standard requires it, such as postal address formatting.

## Usage

Use a shared layout from an origin template:

```razor
<LetterLayout
    Address="Model.Client.Address"
    Subject="Envio de documentação"
    Date="Model.Date"
    TraceText="Model.Trace">
    <p>Exmo.(s) Senhor(es),</p>
    <p>Segue a documentação solicitada.</p>
</LetterLayout>
```

Use shared fragments when the document needs them:

```razor
<SignatureComponent
    Greeting="Com os nossos cumprimentos,"
    SignatureName="Sandra Faro"
    Department="Centro de Formação e Envolvimento Comercial" />

<MBPaymentComponent
    Entity="10420"
    Reference="386246748"
    Value="Model.PremiumDebt.ToPortugueseMoney()" />
```

Use a simple value table when the model carries row values and the template owns column headers/layout:

```razor
<DocumentValueTableComponent
    Data="Model.PaymentLines"
    ColumnDefinitions="PaymentLineColumnDefinitions"
    Style="DocumentValueTableStyle.HeaderUnderline" />

@code {
    private static readonly IReadOnlyList<DocumentValueTableColumnDefinition> PaymentLineColumnDefinitions =
    [
        new("Descrição", width: 70),
        new("Valor", ColumnAlign.Right, 30)
    ];
}
```

`DocumentValueTableStyle.HorizontalLines`, `Grid`, and `None` mirror the generic table visual modes. `HeaderUnderline` is the compact receipt-style header rule.

Table style CSS is split into `Styles/*.razor` files. `DocumentValueTableComponent` only selects which style component is injected.

## Service Flow

```text
Template project references Components
  -> Razor template composes shared components
  -> IRazorComponentRenderer renders the template
  -> optional IPdfGenerator prints the output
```

`PrinterCalibrationPage` is a discoverable A4 document template with key `print-calibration-a4`. It uses `NoDocumentModel` because it intentionally has no business model.

## Project Rules

- Do not put origin contracts here.
- Do not put concrete DOCE or FSCD templates here.
- Keep components reusable and origin-neutral.
- Keep origin-specific wording inside origin templates.
- Put page-level positioning in layouts when the position is layout-specific.
- Put component-specific standards inside the component, such as CTT postal address sizing.
- Avoid hidden data dependencies; pass the data a component needs explicitly.
- Give components with public support files their own folder.
- Put selectable component styles in `Styles/*.razor` files and inject the selected style from the component.
- Keep `DocumentValueTableComponent` simple: row values come from the model; column definitions, percentage widths, per-column alignment, and style selection come from the template.

## Development Workflow

1. Check whether a component is truly reusable before adding it here.
2. Keep visual changes focused and test with the calibration/integration path when print behavior matters.
3. Run component integration tests when changing layouts, calibration, or print-sensitive CSS.
4. Update this README when folders or ownership categories change.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
