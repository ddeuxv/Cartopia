using CartopiaWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CartopiaWeb.Data
{
    public class CartopiaDbContext : IdentityDbContext
    {
        public CartopiaDbContext(DbContextOptions<CartopiaDbContext> options) : base(options) 
        {
            
        }


        DbSet<CarInfo> Cars { get; set; }
    }
}
