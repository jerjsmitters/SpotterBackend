

using API;
using Business;
using Business.Setup;
using Common;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);


//add config
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.RegisterBusinessServices();
builder.Services.InitialiseDataBase(ConnectionString.GetConnectionString());


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();




app.Run();
 