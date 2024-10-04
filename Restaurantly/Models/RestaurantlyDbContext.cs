using Microsoft.EntityFrameworkCore;

namespace Restaurantly.Models
{
    public class RestaurantlyDbContext : DbContext
    {
        public RestaurantlyDbContext(DbContextOptions<RestaurantlyDbContext> options)
            : base(options)
        {
        }

        // Your DbSet properties go here
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryPath> CategoryPaths { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsToCategory> ProductsToCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<BannerImage> BannerImages { get; set; }
    }
}
