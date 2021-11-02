﻿// <auto-generated />
using System;
using FilmKatalogusAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmKatalogusAPI.Migrations
{
    [DbContext(typeof(FilmContext))]
    [Migration("20211102172016_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("FilmKatalogusAPI.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BemutatoDatum")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Cim")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Mufaj")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Filmek");
                });

            modelBuilder.Entity("FilmKatalogusAPI.Models.Szinesz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Keresztnev")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nemzetiseg")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("OscarNyertes")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("SzuletesiDatum")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Vezeteknev")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Szineszek");
                });
#pragma warning restore 612, 618
        }
    }
}
