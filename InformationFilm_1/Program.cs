using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Добавление служб Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Маршрутизация Razor Pages
app.MapRazorPages();

app.MapGet("/", context =>
{
    context.Response.Redirect("/Movies");
    return System.Threading.Tasks.Task.CompletedTask;
});

// Запуск приложения
app.Run();
