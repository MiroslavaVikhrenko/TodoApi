var builder = WebApplication.CreateBuilder(args);

// Add DI - AddService() method when we are registering services into ASP.NET.
var app = builder.Build();

// After building the web app we configure ASP.NET request pipeline - Use and Map methods to configure request lifecycle.


app.Run();
