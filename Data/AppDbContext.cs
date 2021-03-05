using Microsoft.EntityFrameworkCore;

namespace RegisterProductsApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(80);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Product>()
                .HasData(
                            new Product { Id = 1, Name = "ExampleOne", Price = 1.01M, Inventory = 10 },
                            new Product { Id = 2, Name = "ExampleTwo", Price = 2.02M, Inventory = 20 },
                            new Product { Id = 3, Name = "ExampleTree", Price = 3.03M, Inventory = 30 }
                        );
        }
    }
}
