using Microsoft.EntityFrameworkCore;
using System;

namespace Restaurantly.Models
{
    public class RestaurantlyDbContext : DbContext
    {
        public RestaurantlyDbContext(DbContextOptions<RestaurantlyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<BannerImage> BannerImages { get; set; }
        public DbSet<CategoryPath> CategoryPaths { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BookTable> BookTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define seeding data here
            DateTime currentDateTime = DateTime.Now;

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "Admin" },
                new Role { Id = 2, RoleName = "Manager" },
                new Role { Id = 3, RoleName = "Customer" },
                new Role { Id = 4, RoleName = "Staff" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Starters", SortOrder = 1 },
                new Category { Id = 2, Name = "Main Course", SortOrder = 2 },
                new Category { Id = 3, Name = "Desserts", SortOrder = 3 },
                new Category { Id = 4, Name = "Drinks", SortOrder = 4 }
            );

            modelBuilder.Entity<Customer>().HasData(
                    new Customer
                    {
                        Id = 1,
                        FullName = "John Doe",
                        Email = "john@example.com",
                        Phone = "123456789",
                        Password = "hashed_password_1",
                        Status = true,
                        DateAdded = currentDateTime,
                        // UserId = 1 // Adding UserId here
                    },
                    new Customer
                    {
                        Id = 2,
                        FullName = "Jane Smith",
                        Email = "jane@example.com",
                        Phone = "987654321",
                        Password = "hashed_password_2",
                        ResetToken = "MxDAai3K",
                        ResetTokenExpiry = currentDateTime.AddHours(1),
                        Status = true,
                        DateAdded = currentDateTime,
                        // UserId = 1 // Adding UserId here
                    }
                );


            modelBuilder.Entity<Table>().HasData(
                new Table { Id = 1, TableNumber = 1, Seats = 4, Status = true },
                new Table { Id = 2, TableNumber = 2, Seats = 2, Status = true },
                new Table { Id = 3, TableNumber = 3, Seats = 6, Status = false }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    Id = 1,
                    CustomerId = 1,
                    FullName = "John Doe",
                    Email = "johndoe@example.com",
                    Phone = "123456789",
                    NumberOfGuests = 4,
                    ReservationDate = currentDateTime.AddDays(1),
                    ReservationTime = new TimeSpan(19, 0, 0),
                    Message = "Request a quiet table",
                    TableId = 1,
                    ProductId = 1,
                    IsConfirmed = true,
                    DateAdded = currentDateTime,
                    DateModified = currentDateTime
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Caesar Salad",
                    CategoryId = 1,
                    Price = 8.99M,
                    Description = "Classic Caesar salad with fresh ingredients.",
                    Ingredients = "Romaine lettuce, Caesar dressing, Croutons, Parmesan cheese",
                    Featured = true,
                    Image = "caesar-salad.jpg",
                    Status = true,
                    DateAdded = currentDateTime,
                    DateModified = currentDateTime
                },
                new Product
                {
                    Id = 2,
                    Name = "Grilled Chicken",
                    CategoryId = 2,
                    Price = 12.99M,
                    Description = "Perfectly grilled chicken with a hint of lemon.",
                    Ingredients = "Chicken breast, Olive oil, Herbs, Garlic, Lemon zest",
                    Featured = true,
                    Image = "grilled-chicken.jpg",
                    Status = true,
                    DateAdded = currentDateTime,
                    DateModified = currentDateTime
                }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    CustomerId = 1,
                    ReservationId = 1,
                    Total = 30.50M,
                    Status = true,
                    PaymentStatus = true,
                    DateAdded = currentDateTime,
                    DateModified = currentDateTime
                }
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem
                {
                    Id = 1,
                    OrderId = 1,
                    ProductId = 1,
                    Quantity = 2,
                    Price = 8.99M,
                    CustomerId = 1 // Added CustomerId here
                },
                new OrderItem
                {
                    Id = 2,
                    OrderId = 1,
                    ProductId = 2,
                    Quantity = 1,
                    Price = 12.99M,
                    CustomerId = 1 // Added CustomerId here
                }
            );

            modelBuilder.Entity<ProductImages>().HasData(
                new ProductImages { Id = 1, ProductId = 1, Images = "caesar-salad.jpg", SortOrder = 1 },
                new ProductImages { Id = 2, ProductId = 2, Images = "grilled-chicken.jpg", SortOrder = 1 }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin_hashed_password",
                    Email = "admin@example.com",
                    RoleId = 1,
                    Status = true,
                    CreatedAt = currentDateTime
                }
            );

            modelBuilder.Entity<Setting>().HasData(
                new Setting { Id = 1, Key = "SiteName", Value = "Restaurantly" },
                new Setting { Id = 2, Key = "Email", Value = "info@restaurantly.com" }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    FullName = "Michael Brown",
                    Email = "michael@example.com",
                    Phone = "123456789",
                    Subject = "Reservation inquiry",
                    Message = "Can I book a table for 6 people?",
                    DateAdded = currentDateTime,
                    DateModified = currentDateTime,
                    Status = true
                }
            );

            modelBuilder.Entity<BannerImage>().HasData(
                new BannerImage
                {
                    Id = 1,
                    Image = "banner1.jpg",
                    Link = "https://restaurantly.com/banner1",
                    SortOrder = 1,
                    Status = true
                }
            );

            modelBuilder.Entity<CategoryPath>().HasData(
                new CategoryPath { Id = 1, CategoryId = 1, PathId = 0, Level = 1 }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    Id = 1,
                    CustomerId = 1,
                    ProductId = 1,
                    Rating = 5,
                    Comment = "Great Caesar Salad!",
                    DateAdded = currentDateTime
                }
            );

            modelBuilder.Entity<BookTable>().HasData(
                new BookTable
                {
                    Id = 1,
                    FullName = "David Johnson",
                    Email = "david@example.com",
                    Phone = "0987654321",
                    NumberOfGuests = 4,
                    ReservationDate = currentDateTime.AddDays(3),
                    ReservationTime = new TimeSpan(19, 30, 0),
                    TableId = 2,
                    Message = "Looking forward to our dinner!",
                    DateAdded = currentDateTime
                }
            );
        }
    }
}
