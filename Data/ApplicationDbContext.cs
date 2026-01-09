using GreenFantasiaGifts011.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenFantasiaGifts011.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. إعدادات القيود (Constraints)
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2);

            // 2. تعبئة بيانات المستخدمين (User Seed)
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "AdminGreen",
                    Email = "NON@greenfantasia.com",
                    Password = "NON6675",
                    Role = "Admin",
                    CreatedAt = new DateTime(2023, 1, 1)
                }
            );

            // 3. تعبئة بيانات المنتجات (Product Seed) مع إضافة الوصف الإبداعي
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Areca Palm",
                    Price = 20.00m,
                    ImageUrl = "/images/ArecaPalm.png",
                    Category = "Indoor Plants",
                    IsInStock = true,
                    CreatedAt = DateTime.UtcNow,
                    Description = "The ultimate air-purifying indoor palm. This elegant plant features feathery fronds that add a tropical feel to any room. It thrives in bright, indirect light and is safe for pets."
                },
                new Product
                {
                    Id = 2,
                    Name = "Bird of Paradise",
                    Price = 10.00m,
                    ImageUrl = "/images/BirdOfParadise.png",
                    Category = "Tropical Plants",
                    IsInStock = true,
                    CreatedAt = DateTime.UtcNow,
                    Description = "A dramatic tropical plant known for its large, banana-like leaves and stunning flowers. It requires bright light and space to grow, making it a perfect statement piece for large living areas."
                },
                new Product
                {
                    Id = 3,
                    Name = "Snake Plant",
                    Price = 5.00m,
                    ImageUrl = "/images/SnakePlant.png",
                    Category = "Low Light Plants",
                    IsInStock = true,
                    CreatedAt = DateTime.UtcNow,
                    Description = "Vertical, sleek, and nearly indestructible. Perfect for beginners, the Snake Plant can survive in low light conditions and needs very little water. It's also famous for converting CO2 into oxygen at night."
                },
                new Product
                {
                    Id = 4,
                    Name = "Rubber Plant",
                    Price = 13.00m,
                    ImageUrl = "/images/RubberPlant.png",
                    Category = "Indoor Trees",
                    IsInStock = true,
                    CreatedAt = DateTime.UtcNow,
                    Description = "Stunning glossy dark green foliage. The Ficus elastica prefers bright, filtered light. Its broad leaves act as natural dust magnets, helping to clean the air while adding a sophisticated look to your office."
                },
                new Product
                {
                    Id = 5,
                    Name = "Dracaena Trifasciata",
                    Price = 9.00m,
                    ImageUrl = "/images/DracaenaTrifasciata.png",
                    Category = "Low Light Plants",
                    IsInStock = true,
                    CreatedAt = DateTime.UtcNow,
                    Description = "Tough and low maintenance. This variety survives in very low light and needs little water. Its unique variegated patterns make it a visually striking addition to any dark corner."
                }
            );
        }
    }
}