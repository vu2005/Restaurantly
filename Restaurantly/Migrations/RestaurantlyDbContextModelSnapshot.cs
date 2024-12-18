﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurantly.Models;

#nullable disable

namespace Restaurantly.Migrations
{
    [DbContext(typeof(RestaurantlyDbContext))]
    partial class RestaurantlyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Restaurantly.Models.BannerImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("BannerImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "banner1.jpg",
                            Link = "https://restaurantly.com/banner1",
                            SortOrder = 1,
                            Status = true
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.BookTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<TimeSpan>("ReservationTime")
                        .HasColumnType("time(6)");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BookTables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Email = "david@example.com",
                            FullName = "David Johnson",
                            IsConfirmed = false,
                            Message = "Looking forward to our dinner!",
                            NumberOfGuests = 4,
                            Phone = "0987654321",
                            ReservationDate = new DateTime(2024, 11, 18, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            ReservationTime = new TimeSpan(0, 19, 30, 0, 0),
                            TableId = 2
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Starters",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Main Course",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Desserts",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Drinks",
                            SortOrder = 4
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.CategoryPath", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("PathId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryPaths");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Level = 1,
                            PathId = 0
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            DateModified = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Email = "michael@example.com",
                            FullName = "Michael Brown",
                            Message = "Can I book a table for 6 people?",
                            Phone = "123456789",
                            Status = true,
                            Subject = "Reservation inquiry"
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ResetToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ResetTokenExpiry")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Email = "john@example.com",
                            FullName = "John Doe",
                            Password = "hashed_password_1",
                            Phone = "123456789",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Email = "jane@example.com",
                            FullName = "Jane Smith",
                            Password = "hashed_password_2",
                            Phone = "987654321",
                            ResetToken = "MxDAai3K",
                            ResetTokenExpiry = new DateTime(2024, 11, 15, 6, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Status = true
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            DateModified = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            PaymentStatus = true,
                            ReservationId = 1,
                            Status = true,
                            Total = 30.50m
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            OrderId = 1,
                            Price = 8.99m,
                            ProductId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 1,
                            OrderId = 1,
                            Price = 12.99m,
                            ProductId = 2,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Featured")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            DateModified = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Description = "Classic Caesar salad with fresh ingredients.",
                            Featured = true,
                            Image = "caesar-salad.jpg",
                            Ingredients = "Romaine lettuce, Caesar dressing, Croutons, Parmesan cheese",
                            Name = "Caesar Salad",
                            Price = 8.99m,
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            DateModified = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Description = "Perfectly grilled chicken with a hint of lemon.",
                            Featured = true,
                            Image = "grilled-chicken.jpg",
                            Ingredients = "Chicken breast, Olive oil, Herbs, Garlic, Lemon zest",
                            Name = "Grilled Chicken",
                            Price = 12.99m,
                            Status = true
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.ProductImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Images = "caesar-salad.jpg",
                            ProductId = 1,
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Images = "grilled-chicken.jpg",
                            ProductId = 2,
                            SortOrder = 1
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<TimeSpan>("ReservationTime")
                        .HasColumnType("time(6)");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            DateModified = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Email = "johndoe@example.com",
                            FullName = "John Doe",
                            IsConfirmed = true,
                            Message = "Request a quiet table",
                            NumberOfGuests = 4,
                            Phone = "123456789",
                            ProductId = 1,
                            ReservationDate = new DateTime(2024, 11, 16, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            ReservationTime = new TimeSpan(0, 19, 0, 0, 0),
                            TableId = 1
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Great Caesar Salad!",
                            CustomerId = 1,
                            DateAdded = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            ProductId = 1,
                            Rating = 5
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "Manager"
                        },
                        new
                        {
                            Id = 3,
                            RoleName = "Customer"
                        },
                        new
                        {
                            Id = 4,
                            RoleName = "Staff"
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "SiteName",
                            Value = "Restaurantly"
                        },
                        new
                        {
                            Id = 2,
                            Key = "Email",
                            Value = "info@restaurantly.com"
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Seats = 4,
                            Status = true,
                            TableNumber = 1
                        },
                        new
                        {
                            Id = 2,
                            Seats = 2,
                            Status = true,
                            TableNumber = 2
                        },
                        new
                        {
                            Id = 3,
                            Seats = 6,
                            Status = false,
                            TableNumber = 3
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 15, 5, 25, 38, 24, DateTimeKind.Local).AddTicks(7300),
                            Email = "admin@example.com",
                            Password = "admin_hashed_password",
                            RoleId = 1,
                            Status = true,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Restaurantly.Models.CategoryPath", b =>
                {
                    b.HasOne("Restaurantly.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Restaurantly.Models.Order", b =>
                {
                    b.HasOne("Restaurantly.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("Restaurantly.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId");

                    b.Navigation("Customer");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Restaurantly.Models.OrderItem", b =>
                {
                    b.HasOne("Restaurantly.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurantly.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Restaurantly.Models.Product", b =>
                {
                    b.HasOne("Restaurantly.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Restaurantly.Models.ProductImages", b =>
                {
                    b.HasOne("Restaurantly.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Restaurantly.Models.Reservation", b =>
                {
                    b.HasOne("Restaurantly.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurantly.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurantly.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Restaurantly.Models.Review", b =>
                {
                    b.HasOne("Restaurantly.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurantly.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Restaurantly.Models.User", b =>
                {
                    b.HasOne("Restaurantly.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Restaurantly.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Restaurantly.Models.Product", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
