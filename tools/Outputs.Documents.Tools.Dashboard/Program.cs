using Outputs.Documents.Tools.Dashboard.Components;
using Outputs.Documents.Tools.Dashboard.Services;
using Outputs.Documents.Domain.VectorStore;
using Outputs.Documents.Domain.VectorStore.Storage;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var databaseDirectory = ResolveVectorStoreDatabaseDirectory(builder.Configuration);

builder.Services.AddSingleton<IDomainVectorStore>(
    new DomainVectorStore(databaseDirectory));
builder.Services.AddSingleton(new VectorStoreDashboardOptions(databaseDirectory));
builder.Services.AddScoped<VectorStoreSearchService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

static string ResolveVectorStoreDatabaseDirectory(IConfiguration configuration)
{
    var configured = configuration["VectorStore:DatabaseDirectory"];

    if (!string.IsNullOrWhiteSpace(configured))
    {
        return Path.GetFullPath(configured);
    }

    var fromEnvironment = Environment.GetEnvironmentVariable("OUTPUTS_DOCUMENTS_VECTOR_STORE_DB_DIR");

    if (!string.IsNullOrWhiteSpace(fromEnvironment))
    {
        return Path.GetFullPath(fromEnvironment);
    }

    return Path.Combine(FindRepositoryRoot(), "data", "domain-vector-dbs");
}

static string FindRepositoryRoot()
{
    var directory = new DirectoryInfo(AppContext.BaseDirectory);

    while (directory is not null)
    {
        if (File.Exists(Path.Combine(directory.FullName, "Outputs.Documents.sln")))
        {
            return directory.FullName;
        }

        directory = directory.Parent;
    }

    return Directory.GetCurrentDirectory();
}
