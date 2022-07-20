using Microsoft.EntityFrameworkCore;
using RazerPizzeria.Models;

namespace RazerPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
