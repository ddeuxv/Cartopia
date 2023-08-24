using CartopiaWeb.Data;
using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;
using CartopiaWeb.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICarsReceiver, CarsReceiverService>();
builder.Services.AddScoped<ICarCreator, CarCreatorService>();
builder.Services.AddScoped<IPhotoConverter, PhotoConverterService>();
builder.Services.AddScoped<ICarEditor, CarRemoverService>();


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CartopiaDbContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddSignInManager<SignInManager<ApplicationUser>>()
    .AddEntityFrameworkStores<CartopiaDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();