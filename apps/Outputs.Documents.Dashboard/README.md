# Outputs.Documents.Dashboard

Development Blazor dashboard for Outputs.Documents tool UIs.

Current scope:

- Empty dashboard shell only.
- Shared layout, navigation frame, top status bar, and placeholder home surface.
- No tool pages and no domain/vector-store service wiring.

Run from the repository root:

```bash
dotnet run --project apps/Outputs.Documents.Dashboard/Outputs.Documents.Dashboard.csproj --launch-profile http
```

Open:

```text
http://localhost:5090
```

The UI is intentionally only a shell for now. It borrows the shared dashboard direction from `/Users/thepotato/Code/Dashboard`: persistent left navigation, top status bar, and a constrained content surface. Tool UIs can be added later without changing the frame.
