
using LanchoneteMVC.Data;
using LanchoneteMVC.Models;
using LanchoneteMVC.Repositories;
using LanchoneteMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext com SQLite
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

// Registrar Repositórios
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ILancheRepository, LancheRepository>();

// Adicionar serviço de Controllers com Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
