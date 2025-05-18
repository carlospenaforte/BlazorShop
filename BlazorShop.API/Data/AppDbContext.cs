using BlazorShop.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Cart>? Carts { get; set; }
        public DbSet<CarItem>? CarItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Smartphones",
                    IconCSS = "fa-solid fa-mobile-screen-button"
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Samsung S12",
                    Description = "Smartphone with 12px camera",
                    ImageURL = "/Images/Smartphones/Smartphone1.png",
                    Price = 100,
                    Quantity = 10,
                    CategoryId = 1
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "John"
                });
        }
    }
}
