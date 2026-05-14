# Outputs.Documents.Domain.VectorStore.McpServer

Development MCP server for the domain vector store.

The server exposes the storage/search operations from `Outputs.Documents.Domain.VectorStore` over MCP HTTP by default. It does not generate embeddings. Callers must pass already encoded vectors.

## Run

HTTP is the default transport:

```bash
dotnet run --project tools/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj -- --urls http://localhost:5055
```

MCP endpoint:

```text
http://localhost:5055/mcp
```

Stdio is still available when a local MCP host wants to spawn the process:

```bash
dotnet run --project tools/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj -- --transport stdio
```

By default the server uses:

```text
data/domain-vector-dbs/
```

Override the DB folder with either:

```bash
OUTPUTS_DOCUMENTS_VECTOR_STORE_DB_DIR=/path/to/dbs dotnet run --project tools/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj
```

or:

```bash
dotnet run --project tools/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj -- --db-dir /path/to/dbs --urls http://localhost:5055
```

## Tools

- `ListAlignmentPrompts`
- `ListModelsAsync`
- `UpsertRecordAsync`
- `GetRecordAsync`
- `ListRecordsAsync`
- `DeleteRecordAsync`
- `DeleteByDeclarationAsync`
- `ExactSearchAsync`
- `VectorSearchAsync`
- `HybridSearchAsync`
- `SaveAlignmentSetAsync`
- `CheckAlignmentAsync`

## Notes

- `GetRecordAsync` is exact id lookup only.
- Exact/vector/hybrid search are separate tools.
- Alignment uses the fixed prompts returned by `ListAlignmentPrompts`.
- This MCP server stores vectors only; embedding generation belongs to the caller.
