using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebShopFresh.Data;
using WebShopFresh.Mapping;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Implementation;
using WebShopFresh.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(opts => {
    opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:DefaultConnection"]);
});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

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

builder.Services.AddSingleton<IIdentitySetup, IdentitySetup>();

builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IOrderService, OrderService>();

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddRazorPages();

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
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Products}/{id?}");
app.MapRazorPages();

var identitySetup = app.Services.GetRequiredService<IIdentitySetup>();
app.Run();
