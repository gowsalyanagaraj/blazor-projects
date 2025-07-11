using Prototype.Web.Components;
using Prototype.Web.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
       .AddInteractiveServerComponents();
builder.Services.AddScoped<StateContainer>();
WebApplication app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();