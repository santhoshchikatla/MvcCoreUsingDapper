using Microsoft.EntityFrameworkCore;
using webapp.DAL;
using WebApp.Data.DataAccess;
using WebApp.Data.Repositary;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISQLDataAccess, SQLDataAccess>();
builder.Services.AddTransient<IPersonRepositary, PersonRepositary>();
builder.Services.AddTransient<IRegistrationRepositary, RegistrationRepositary>();

builder.Services.AddDbContext<MyAppDbContext>(options => options.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.Run();
