using iShopMain.Data;
using iShopMain.Models.Entity.UserInfo;
using iShopMain.Repositories;
using iShopMain.Repositories.User;      
using iShopMain.Services;
using iShopMainVer2.Repositories.User;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
 
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString)); // ������ ��

builder.Services.AddDatabaseDeveloperPageExceptionFilter(); // ��������� ����������, ��������� � ��, ������� ����� ������ � ������� ��������

builder.Services.AddControllers();

builder.Services.AddScoped<ApplicationDbContext>();


builder.Services.AddScoped<IRepository<AppUser>, UserRepository>();
builder.Services.AddScoped<IRepository<Account>, AccountRepository>();
builder.Services.AddScoped<IRepository<Information>, InformationRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IService, UserService>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie( options =>
        {
            options.LoginPath = "/login";
            options.AccessDeniedPath = "/accessdenied";
        }
    );


var app = builder.Build();

app.UseHttpsRedirection();

//app.UseAuthentication();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.Run();
