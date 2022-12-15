using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOcelot().AddCacheManager(settings=>settings.WithDictionaryHandle());


//To Add ocelot.json file
builder.Configuration.AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json",true,true);

//var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
//builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
//    .AddJsonFile($"ocelot.{environment}.json", optional: false, reloadOnChange: true)
//    .AddEnvironmentVariables();

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

