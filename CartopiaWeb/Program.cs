using CartopiaWeb.Data;
using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;
using CartopiaWeb.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICarsReceiver, CarsReceiverRepository>();
builder.Services.AddScoped<ICarCreator, CarCreatorRepository>();
builder.Services.AddScoped<IPhotoConverter, PhotoConverterRepository>();
builder.Services.AddScoped<ICarRemover, CarRemoverRepository>();


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