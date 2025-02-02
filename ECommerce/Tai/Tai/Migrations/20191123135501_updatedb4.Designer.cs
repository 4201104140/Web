﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tai.DataModels;

namespace Tai.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20191123135501_updatedb4")]
    partial class updatedb4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tai.DataModels.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(6);

                    b.Property<string>("CategoryIcon")
                        .HasMaxLength(20);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("CategoryParentId")
                        .HasMaxLength(6);

                    b.Property<string>("CategoryRemark")
                        .HasMaxLength(250);

                    b.HasKey("CategoryId");

                    b.HasIndex("CategoryParentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Tai.DataModels.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .HasMaxLength(250);

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Tai.DataModels.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(6);

                    b.Property<string>("Barcode");

                    b.Property<string>("CategoryId")
                        .HasMaxLength(6);

                    b.Property<string>("Images")
                        .HasMaxLength(100);

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductDetail");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<double>("ProductPrice");

                    b.Property<int>("ProductQuantity");

                    b.Property<double>("SaleOff");

                    b.Property<DateTime>("SaleOffDate");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Tai.DataModels.Category", b =>
                {
                    b.HasOne("Tai.DataModels.Category", "CategoryParent")
                        .WithMany("Categories")
                        .HasForeignKey("CategoryParentId");
                });

            modelBuilder.Entity("Tai.DataModels.Product", b =>
                {
                    b.HasOne("Tai.DataModels.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
