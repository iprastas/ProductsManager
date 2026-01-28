using Microsoft.EntityFrameworkCore;
using IronWaterStudio_Test_Stoianova.Models;

namespace IronWaterStudio_Test_Stoianova.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Хлеб", Description = "Из ближайшей пекарни", Price = 50.00m},
                new Product { Id = 2, Name = "Молоко", Description = "Светаево", Price = 89.99m},
                new Product { Id = 3, Name = "Курица", Description = "1 кг", Price = 359.99m }
            );
        }
    }
}
