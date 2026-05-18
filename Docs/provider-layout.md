# Origin Workspaces

Origin workspaces contain origin-specific contracts, Razor templates, and origin-owned tests.

Each origin folder is shaped as an extraction boundary so it can later become its own repository while still referencing the shared platform projects from root `Core/src/`.

```text
<PROVIDER>/
  src/
    Outputs.Documents.<PROVIDER>.Contracts/
    Outputs.Documents.<PROVIDER>.Templates/
  tests/
    Outputs.Documents.<PROVIDER>.<Area>.UnitTests/
    Outputs.Documents.<PROVIDER>.<Area>.IntegrationTests/

Example:

DOCE/
  src/
    Outputs.Documents.DOCE.Contracts/
    Outputs.Documents.DOCE.Templates/
  tests/
    Outputs.Documents.DOCE.Templates.UnitTests/
    Outputs.Documents.DOCE.Templates.IntegrationTests/

FSCD/
  src/
    Outputs.Documents.FSCD.Contracts/
    Outputs.Documents.FSCD.Templates/
  tests/
    Outputs.Documents.FSCD.Templates.IntegrationTests/
```

Rules:

- Put source-system/copybook contracts under the origin `src/` folder.
- Put concrete Razor document templates and template rules under the same origin `src/` folder.
- Put origin-specific unit and integration tests under the origin `tests/` folder.
- Keep shared rendering, domain, component, and tool code out of origin workspaces.
- Origin projects may reference core projects in root `Core/src/`; core projects must not reference origin workspaces.
