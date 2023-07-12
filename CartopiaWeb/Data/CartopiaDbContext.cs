using CartopiaWeb.Configuration;
using CartopiaWeb.Controllers;
using CartopiaWeb.Extensions;
using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CartopiaWeb.Data
{
    public class CartopiaDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IPhotoConverter _photoConverter;

        public CartopiaDbContext(DbContextOptions<CartopiaDbContext> options, IPhotoConverter photoConverter) : base(options)
        {
            _photoConverter = photoConverter;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SeedInitialCars(_photoConverter);
            builder.ApplyConfiguration(new RoleConfiguration());
            
        }

        public DbSet<CarInfo> Cars { get; set; }
    }
}
