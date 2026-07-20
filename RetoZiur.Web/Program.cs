using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http.Headers;
using RetoZiur.Web;
using RetoZiur.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var token = builder.Configuration["ZiurApiToken"];

builder.Services.AddScoped(sp => 
{
    var http = new HttpClient { BaseAddress = new Uri("https://mainserver.ziursoftware.com/") };
    http.DefaultRequestHeaders.Authorization =
        new AuthenticationHeaderValue("Bearer", token);
    return http;
});
builder.Services.AddScoped<ItemService>();

await builder.Build().RunAsync();
