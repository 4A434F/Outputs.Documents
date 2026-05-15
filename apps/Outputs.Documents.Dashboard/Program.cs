using Outputs.Documents.Dashboard.Components;
using Outputs.Documents.Samples;
using Outputs.Documents.Rendering;
using Outputs.Documents.Templates;
using Outputs.Documents.DOCE.Templates;
using Outputs.Documents.FSCD.Templates;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddOptions<StaticFilePaths>();

builder.Services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithDocumentsFromAssembly(typeof(FS1040CancellationCdc1PremiumTemplate).Assembly)
    .WithSamplesFromAssembly(typeof(Outputs.Documents.DOCE.Contracts.DC000CoverPage).Assembly)
    .WithSamplesFromAssembly(typeof(Outputs.Documents.FSCD.Contracts.BGOW0044Contract).Assembly);

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
