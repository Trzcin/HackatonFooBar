﻿// <auto-generated />
using EFDataAccessLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDataAccessLibrary.Migrations
{
    [DbContext(typeof(PlaceContext))]
    [Migration("20230113034346_AddMapEdges")]
    partial class AddMapEdges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFDataAccessLibrary.Models.MapEdges", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("MaxLat")
                        .HasColumnType("float");

                    b.Property<double>("MaxLon")
                        .HasColumnType("float");

                    b.Property<double>("MinLat")
                        .HasColumnType("float");

                    b.Property<double>("MinLon")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MapEdges");
                });

            modelBuilder.Entity("EFDataAccessLibrary.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<string>("Link")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<double>("Lon")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });
#pragma warning restore 612, 618
        }
    }
}