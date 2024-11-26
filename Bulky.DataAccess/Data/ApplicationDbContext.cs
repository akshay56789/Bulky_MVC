using Bulky.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        public DbSet<OrderHeader> OrderHeaders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Slice Of Life", DisplayOrder = 2 },
                new Category { Id = 2, Name = "RomCom", DisplayOrder = 3 },
                new Category { Id = 3, Name = "Drama", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of time",
                    Author = "James Spark",
                    Description = "None",
                    ISBN = "SWD9990001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Nisekoi",
                    Author = "Ayaka Ohashi",
                    Description = "Romcom Manga",
                    ISBN = "SWD9990002",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Lawson",
                    StreetAddress = "2 Chome-3-1 Marunouchi",
                    City = "Chiyoda",
                    State = "Tokyo Prefecture",
                    PostalCode = "100-0005",
                    PhoneNumber = "7273746456"
                },
                new Company
                {
                    Id = 2,
                    Name = "Dears Myeongdong",
                    StreetAddress = "176 Toegye-ro",
                    City = "Jung District",
                    State = "Seoul",
                    PostalCode = "009003",
                    PhoneNumber = "75675675678"
                }
                );
        }
    }
}
