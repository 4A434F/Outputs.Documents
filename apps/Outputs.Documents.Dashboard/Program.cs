using Outputs.Documents.Dashboard.Components;
using Outputs.Documents.Domain.Samples;
using Outputs.Documents.Rendering;
using Outputs.Documents.Templates;
using Outputs.Documents.Templates.DOCE;
using Outputs.Documents.Templates.FSCD;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddOptions<StaticFilePaths>();

builder.Services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithDocumentsFromAssembly(typeof(FS1040CancellationCdc1PremiumTemplate).Assembly)
    .WithSamplesFromAssembly(typeof(IDocumentModelSample<>).Assembly);

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
