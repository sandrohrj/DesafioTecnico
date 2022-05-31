using Desafio_Sandro_Henrique.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<BancoContext>
    (options => options.UseSqlServer(Configuration.GetConnectionString("DataBase")));
//("Data Source=DESKTOP-4SKMGQI\\MSSQLSERVERR;Initia Catalog=CRUD_MVC_SQL_DESAFIO_SANDRO;Integrated Security=False;User ID=DESKTOP-4SKMGQI\\sandr;Password=;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")); ; ;
//"Data Source=DESKTOP-4SKMGQI\\MSSQLSERVERR;Initial Catalog=CRUD_MVC_SQL_DESAFIO_SANDRO;Integrated Security=True"

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
