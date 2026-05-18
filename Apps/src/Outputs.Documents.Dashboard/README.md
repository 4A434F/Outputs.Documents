# Outputs.Documents.Dashboard

Development Blazor dashboard shell for Outputs.Documents tool UIs.

The dashboard exists to become the common browser interface for preview, inspection, search, and other development workflows. It is intentionally an app shell right now, not a production rendering service.

## Status

- Maturity: development app shell
- Runtime: .NET 8 Blazor
- Current scope: layout, navigation frame, top status bar, and placeholder home surface
- Important warning: no real tool pages are currently wired

## Fast Start

Run from the repository root:

```bash
dotnet run --project Apps/src/Outputs.Documents.Dashboard/Outputs.Documents.Dashboard.csproj --launch-profile http
```

Open:

```text
http://localhost:5090
```

Build:

```bash
dotnet build Apps/src/Outputs.Documents.Dashboard/Outputs.Documents.Dashboard.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `Components/` | Blazor app, routes, layout, navigation, and pages |
| `Properties/launchSettings.json` | IDE and `dotnet run` launch profiles |
| `wwwroot/` | Dashboard CSS and static assets |
| `Program.cs` | App startup and service registration |

## Architecture Summary

The dashboard is an app composition point. It may reference core, origin, and tool projects when a UI needs them, but those libraries should not reference the dashboard.

```text
Dashboard
  -> tool UI pages
  -> core rendering/sample/vector services
  -> origin assemblies for template/sample discovery
```

## Usage

The current app is a shell. Add future tool pages under `Components/Pages/` and register only the services that page needs.

## Service Flow

```text
Program.cs
  -> AddRazorComponents()
  -> dashboard services
  -> MapRazorComponents<App>()
```

Future pages should keep tool-specific service composition explicit so the dashboard does not quietly become production runtime code.

## Project Rules

- Keep this as a development UI, not a production rendering API.
- Do not move reusable tool logic into the dashboard; keep reusable logic in `Tools/src`.
- Do not move rendering logic into the dashboard; use core services.
- Keep launch profiles named `http` and `https` so IDE run configurations remain stable.

## Development Workflow

1. Add reusable logic to a tool/core project first.
2. Add dashboard UI only as the browser interface over that logic.
3. Run the dashboard locally after UI changes.
4. Update this README when launch profiles, ports, or page ownership changes.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
