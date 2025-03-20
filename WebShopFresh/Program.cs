using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebShopFresh.Data;
using WebShopFresh.Mapping;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Implementation;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Dto;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<AppSettings>(builder.Configuration);
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));



// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(opts => {
    opts.UseSqlServer(connectionString);
});



builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSingleton<IIdentitySetup, IdentitySetup>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICommonService, CommonService>();
builder.Services.AddSingleton<IHostedService, QueueProcessor>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDefaultIdentity<ApplicationUser>(
       options => {
                   options.SignIn.RequireConfirmedAccount = true;
                   options.Password.RequiredLength = 6;
                   options.Password.RequiredUniqueChars = 0;
                   options.Password.RequireLowercase = false;
                   options.Password.RequireUppercase = false;

                   options.Password.RequireNonAlphanumeric = false;
                   options.Password.RequireDigit = false;
               }
               )
               .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<ApplicationDbContext>();

// Add session support
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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

//Add session middleware
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Products}/{id?}");
app.MapRazorPages();

var identitySetup = app.Services.GetRequiredService<IIdentitySetup>();
app.Run();
