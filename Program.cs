var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello from .NET 9 on Azure App Service!");

app.Run();
