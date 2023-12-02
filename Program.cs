using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using signup_login.Areas.Identity.Data;
using signup_login.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("signup_loginContextConnection") ?? throw new InvalidOperationException("Connection string 'signup_loginContextConnection' not found.");

builder.Services.AddDbContext<signup_loginContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<signup_loginUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<signup_loginContext>();

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
app.MapRazorPages();
app.Run();
