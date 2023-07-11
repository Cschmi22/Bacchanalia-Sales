﻿// <auto-generated />
using System;
using Bacchanalia_Sales.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bacchanalia_Sales.Migrations
{
    [DbContext(typeof(MVCDemoDbContext))]
    partial class MVCDemoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bacchanalia_Sales.Models.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FridaySales")
                        .HasColumnType("int");

                    b.Property<int>("MondaySales")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SaturdaySales")
                        .HasColumnType("int");

                    b.Property<int>("ThursdaySales")
                        .HasColumnType("int");

                    b.Property<int>("TuesdaySales")
                        .HasColumnType("int");

                    b.Property<int>("WednesdaySales")
                        .HasColumnType("int");

                    b.Property<DateTime>("Week")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
