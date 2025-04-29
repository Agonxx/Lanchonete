using Lanchonete.WEB;
using Lanchonete.WEB.Utils;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.SetupApis(builder.Configuration, builder.Configuration["UrlAPI"]);
builder.Services.SetupServices();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
