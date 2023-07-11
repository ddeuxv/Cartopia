using CartopiaWeb.Configuration;
using CartopiaWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CartopiaWeb.Data
{
    public class CartopiaDbContext : IdentityDbContext<ApplicationUser>
    {
        public CartopiaDbContext(DbContextOptions<CartopiaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<CarInfo> Cars { get; set; }
    }
}
