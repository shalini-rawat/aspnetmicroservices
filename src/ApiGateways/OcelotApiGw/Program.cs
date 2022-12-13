using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOcelot();
builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddDebug();
    logging.AddConsole();
});
var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.UseOcelot();
app.Run();

