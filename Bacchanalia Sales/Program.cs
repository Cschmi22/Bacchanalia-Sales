using Bacchanalia_Sales.Data;
using Microsoft.EntityFrameworkCore;
using MySql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//var connectionString = builder.Configuration.GetConnectionString("ConnectionStrings");
builder.Services.AddDbContext<MVCDemoDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings")));

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
