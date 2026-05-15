# Outputs.Documents.Components

Shared Razor components and document utility pages.

This project contains reusable presentation pieces used by origin-specific templates. It should not contain DOCE or FSCD document contracts. Origin-specific templates live under `origins/`.

## Folder Structure

```text
Outputs.Documents.Components/
  Configuration/
  Documents/
    Calibration/
    Layouts/
    Models/
    Primitives/
  Expedition/
  Locations/
```

## What Lives Where

- `Configuration/`: options and static file path helpers used by shared document components.
- `Documents/`: document-level shared components such as headers, footers, trace identifiers, overlays, and diagnostic pages.
- `Documents/Calibration/`: printable calibration documents used to validate page size, absolute CSS units, font sizing, and line weights.
- `Documents/Layouts/`: reusable page layout wrappers.
- `Documents/Models/`: shared component support models only.
- `Documents/Primitives/`: small generic document components, such as tables.
- `Expedition/`: reusable expedition or postal components.
- `Locations/`: reusable location and address components.

## Calibration Page

`PrinterCalibrationPage` is a discoverable A4 document template with key `print-calibration-a4`.

It is intended for printer and PDF validation:

- A4 page size: `210mm x 297mm`.
- Visible page border.
- Absolute CSS dimension references in `mm`, `cm`, `in`, and `px`.
- Arial font samples across multiple point sizes and weights.
- Line weight references.

The page intentionally has no `Model` parameter. Template discovery maps it to `NoDocumentModel`, which keeps the registry model-shaped without requiring fake calibration data.
