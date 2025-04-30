using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PilamungaS_Taller.Data;
using PilamungaS_Taller.Repositorios;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PilamungaS_TallerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PilamungaS_TallerContext") ?? throw new InvalidOperationException("Connection string 'PilamungaS_TallerContext' not found.")));

builder.Services.AddScoped<ReporteRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
