using Prototype.Web.Components;
using Prototype.Web.Interfaces;
using Prototype.Web.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
       .AddInteractiveServerComponents();

builder.Services.AddSingleton<ISingletonService, WeatherService>();
builder.Services.AddScoped<IScopedService, WeatherService>();
builder.Services.AddTransient<ITransientService, WeatherService>();

WebApplication app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();