using Bacchanalia_Sales.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Bacchanalia_Sales.Data
{
    public class MVCDemoDbContext : DbContext
    { 
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get ; set; }
    }
}
