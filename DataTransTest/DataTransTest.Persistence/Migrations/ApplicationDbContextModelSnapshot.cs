﻿// <auto-generated />
using System;
using DataTransTest.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataTransTest.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataTransTest.Domain.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsPublish")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("DataTransTest.Domain.Entity.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3772),
                            Email = "adffaf@gmail.com",
                            FirstName = "ahmeed",
                            LastName = "ali",
                            Phone = "454646464",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3768)
                        },
                        new
                        {
                            Id = 2,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3781),
                            Email = "ssd2af@gmail.com",
                            FirstName = "salah",
                            LastName = "ali",
                            Phone = "454646464",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3778)
                        },
                        new
                        {
                            Id = 3,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3785),
                            Email = "example1@gmail.com",
                            FirstName = "hany",
                            LastName = "abdu",
                            Phone = "123456789",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 278, DateTimeKind.Local).AddTicks(3783)
                        });
                });

            modelBuilder.Entity("DataTransTest.Domain.Entity.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("UpdatedById")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "منشور تجريبي",
                            CreatedById = 1,
                            CreationDate = new DateTime(2024, 2, 21, 6, 50, 9, 279, DateTimeKind.Utc).AddTicks(7249),
                            IsPublished = true,
                            Title = "داتا ترانس",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("DataTransTest.Domain.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DataTransTest.Domain.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4716),
                            Email = "adffaf@gmail.com",
                            FirstName = "علي",
                            LastName = "الدعيس",
                            Phone = "454646464",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4711)
                        },
                        new
                        {
                            Id = 2,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4722),
                            Email = "ssd2af@gmail.com",
                            FirstName = "سعيد",
                            LastName = "صالح",
                            Phone = "454646464",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4720)
                        },
                        new
                        {
                            Id = 3,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4729),
                            Email = "example1@gmail.com",
                            FirstName = "محمد",
                            LastName = "خالد",
                            Phone = "123456789",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4727)
                        },
                        new
                        {
                            Id = 4,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4732),
                            Email = "example2@gmail.com",
                            FirstName = "فاطمة",
                            LastName = "علي",
                            Phone = "987654321",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4730)
                        },
                        new
                        {
                            Id = 5,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4739),
                            Email = "example3@gmail.com",
                            FirstName = "أحمد",
                            LastName = "عبدالله",
                            Phone = "555555555",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4734)
                        },
                        new
                        {
                            Id = 6,
                            Address = "sanaa",
                            CreatedAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4743),
                            Email = "example4@gmail.com",
                            FirstName = "ريم",
                            LastName = "محمد",
                            Phone = "666666666",
                            UpdateAt = new DateTime(2024, 2, 21, 9, 50, 9, 280, DateTimeKind.Local).AddTicks(4741)
                        });
                });

            modelBuilder.Entity("DataTransTest.Domain.Entity.Comment", b =>
                {
                    b.HasOne("DataTransTest.Domain.Entity.Post", "Posts")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("DataTransTest.Domain.Entity.Post", b =>
                {
                    b.HasOne("DataTransTest.Domain.Entity.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataTransTest.Domain.Entity.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
