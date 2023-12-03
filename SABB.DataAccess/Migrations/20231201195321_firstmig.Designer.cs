﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SABB.DataAccess.Context;

#nullable disable

namespace SABB.DataAccess.Migrations
{
    [DbContext(typeof(SABBDbContext))]
    [Migration("20231201195321_firstmig")]
    partial class firstmig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodMeal", b =>
                {
                    b.Property<int>("FoodsId")
                        .HasColumnType("int");

                    b.Property<int>("MealsMealId")
                        .HasColumnType("int");

                    b.HasKey("FoodsId", "MealsMealId");

                    b.HasIndex("MealsMealId");

                    b.ToTable("FoodMeal");
                });

            modelBuilder.Entity("SABB.Domain.Concrete.Dietitian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DietitianId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dietitians");
                });

            modelBuilder.Entity("SABB.Domain.Concrete.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FoodId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodType")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 200.0,
                            Description = "Beyaz peynir",
                            FoodType = 12,
                            Name = "Peynir",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Calories = 150.0,
                            Description = "Siyah Zeytin",
                            FoodType = 12,
                            Name = "Zeytin",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            Calories = 400.0,
                            Description = "Et Ürünü",
                            FoodType = 6,
                            Name = "Kebap",
                            Status = 1
                        });
                });

            modelBuilder.Entity("SABB.Domain.Concrete.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MealId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("FoodPortion")
                        .HasColumnType("float");

                    b.Property<int?>("FoodQuantity")
                        .HasColumnType("int");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<double>("TotalCalorie")
                        .HasColumnType("float");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("MealId");

                    b.HasIndex("UserId", "Date", "MealType")
                        .IsUnique();

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("SABB.Domain.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("DailyCalorieGoal")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DietitianId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DietitianId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 12, 1, 22, 53, 21, 484, DateTimeKind.Local).AddTicks(630),
                            Email = "admin@admin",
                            FirstName = "Admin",
                            Gender = 1,
                            LastName = "Admin",
                            Password = "SABB",
                            Status = 1,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("FoodMeal", b =>
                {
                    b.HasOne("SABB.Domain.Concrete.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SABB.Domain.Concrete.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsMealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SABB.Domain.Concrete.Meal", b =>
                {
                    b.HasOne("SABB.Domain.Concrete.User", "User")
                        .WithMany("Meals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SABB.Domain.Concrete.User", b =>
                {
                    b.HasOne("SABB.Domain.Concrete.Dietitian", "Dietitian")
                        .WithMany("Users")
                        .HasForeignKey("DietitianId");

                    b.Navigation("Dietitian");
                });

            modelBuilder.Entity("SABB.Domain.Concrete.Dietitian", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SABB.Domain.Concrete.User", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
