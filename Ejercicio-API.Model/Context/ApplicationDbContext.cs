using Ejercicio_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
