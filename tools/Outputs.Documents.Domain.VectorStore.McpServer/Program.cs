using Outputs.Documents.Domain.VectorStore;
using Outputs.Documents.Domain.VectorStore.McpServer;
using Outputs.Documents.Domain.VectorStore.Storage;

var transport = VectorStoreMcpTransportResolver.Resolve(args);
var databaseDirectory = VectorStoreDatabaseDirectory.Resolve(args);

if (transport == VectorStoreMcpTransport.Http)
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddSingleton<IDomainVectorStore>(
        new DomainVectorStore(databaseDirectory));

    builder.Services
        .AddMcpServer()
        .WithHttpTransport()
        .WithToolsFromAssembly();

    var app = builder.Build();
    app.MapMcp("/mcp");
    await app.RunAsync();
}
else
{
    var builder = Host.CreateApplicationBuilder(args);

    builder.Logging.AddConsole(options =>
    {
        options.LogToStandardErrorThreshold = LogLevel.Trace;
    });

    builder.Services.AddSingleton<IDomainVectorStore>(
        new DomainVectorStore(databaseDirectory));

    builder.Services
        .AddMcpServer()
        .WithStdioServerTransport()
        .WithToolsFromAssembly();

    await builder.Build().RunAsync();
}
