using DataDome.Configuration;
using DataDome;

//minimal demo webapp based on : https://learn.microsoft.com/fr-fr/visualstudio/mac/asp-net-core?view=vsmac-2022

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<DataDomeConfig>(builder.Configuration.GetSection("DataDomeConfiguration"));

var app = builder.Build();

app.UseDataDome();

app.MapGet("/", () => "Hello ASP.NET Core!");

app.Run();
