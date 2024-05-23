﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetapp.Data;

#nullable disable

namespace dotnetapp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240522061806_InitialSetup")]
    partial class InitialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dotnetapp.Models.Laptop", b =>
                {
                    b.Property<int>("laptopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("laptopId"), 1L, 1);

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("storage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("laptopId");

                    b.ToTable("Laptops");
                });
#pragma warning restore 612, 618
        }
    }
}
