
using BasketAPI.Repositories;
using Microsoft.Extensions.Configuration;

//IConfiguration configuration = new ConfigurationBuilder()
//                            .AddJsonFile("appsettings.json")
//                            .Build();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register objects into implementaion class. convert Interface object into implementation
builder.Services.AddScoped<IBasketRepository, BasketRepository>();


//Register Redis configuration. Register Objects
builder.Services.AddStackExchangeRedisCache(options=>
{
    options.Configuration = builder.Configuration["CacheSettings:ConnectionString"];
}
);
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
