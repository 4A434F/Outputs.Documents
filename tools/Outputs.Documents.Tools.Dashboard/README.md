# Outputs.Documents.Tools.Dashboard

Development Blazor dashboard for Outputs.Documents tool UIs.

Current scope:

- Search-only domain vector store UI.
- No add, edit, or delete operations.
- Uses the repo-local vector store by default: `data/domain-vector-dbs`.
- Can be pointed at another store with `VectorStore:DatabaseDirectory` or `OUTPUTS_DOCUMENTS_VECTOR_STORE_DB_DIR`.

Run from the repository root:

```bash
dotnet run --project tools/Outputs.Documents.Tools.Dashboard/Outputs.Documents.Tools.Dashboard.csproj --launch-profile http
```

Open:

```text
http://localhost:5090
```

The UI is intentionally self-contained for now. It borrows the shared dashboard direction from `/Users/thepotato/Code/Dashboard`: persistent left navigation, top status bar, compact metric cards, and dense operational panels. As more tool UIs appear, shared dashboard components can be extracted into a reusable project.
