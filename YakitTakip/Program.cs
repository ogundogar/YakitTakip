using Microsoft.EntityFrameworkCore;
using YakitTakip.IRepository;
using YakitTakip.IRepository.Arac;
using YakitTakip.IRepository.Personel;
using YakitTakip.Models;
using YakitTakip.Repository;
using YakitTakip.Repository.Arac;
using YakitTakip.Repository.Personel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbYakitTakipContext>();
builder.Services.AddScoped<IPersonelReadRepository,PersonelReadRepository>();
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
