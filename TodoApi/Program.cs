using Microsoft.EntityFrameworkCore;
using TodoApi;

var builder = WebApplication.CreateBuilder(args);

// Add DI - AddService() method when we are registering services into ASP.NET.

builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));

var app = builder.Build();

// After building the web app we configure ASP.NET request pipeline - Use and Map methods to configure request lifecycle.


app.Run();
