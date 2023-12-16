﻿// <auto-generated />
using System;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(ZodiacContext))]
    [Migration("20231215234925_CompatibleZodiacs")]
    partial class CompatibleZodiacs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Database.Models.CompatibleZodiacs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompatibleZodiacId")
                        .HasColumnType("int");

                    b.Property<int>("ZodiacId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompatibleZodiacId");

                    b.HasIndex("ZodiacId");

                    b.ToTable("CompatibleZodiacs");
                });

            modelBuilder.Entity("Database.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Database.Models.Zodiac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("FromDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("ToDate")
                        .HasColumnType("date");

                    b.Property<string>("ZodiacSign")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zodiacs");
                });

            modelBuilder.Entity("Database.Models.CompatibleZodiacs", b =>
                {
                    b.HasOne("Database.Models.Zodiac", "CompatibleZodiac")
                        .WithMany()
                        .HasForeignKey("CompatibleZodiacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Models.Zodiac", "Zodiac")
                        .WithMany()
                        .HasForeignKey("ZodiacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompatibleZodiac");

                    b.Navigation("Zodiac");
                });
#pragma warning restore 612, 618
        }
    }
}
