using Outputs.Documents.Preview;
using Outputs.Documents.PreviewHost.Components;
using Outputs.Documents.Templates.Doce;
using FscdDocumentTemplate = Outputs.Documents.Templates.FSCD.FscdDocumentTemplate;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddRazorDocumentPreview()
    .WithDocumentPreviewAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithDocumentPreviewAssembly(typeof(FscdDocumentTemplate).Assembly);

var doceProjectRoot = FindProjectRoot("src", "Outputs.Documents.Templates.Doce");
var doceWwwroot = Path.Combine(doceProjectRoot, "wwwroot");

builder.Services.Configure<StaticFilePaths>(options =>
{
    options.Path = doceWwwroot;
    options.Logos = Path.Combine(doceWwwroot, "Logos");
    options.Fonts = Path.Combine(doceWwwroot, "fonts");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

static string FindProjectRoot(params string[] segments)
{
    var directory = new DirectoryInfo(AppContext.BaseDirectory);

    while (directory is not null)
    {
        var candidate = Path.Combine(new[] { directory.FullName }.Concat(segments).ToArray());

        if (Directory.Exists(candidate))
        {
            return candidate;
        }

        directory = directory.Parent;
    }

    return Path.Combine(Directory.GetCurrentDirectory(), Path.Combine(segments));
}
