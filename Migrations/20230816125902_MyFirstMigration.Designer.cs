﻿// <auto-generated />
using System;
using ApiPreview_ThanhTan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiPreview_ThanhTan.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230816125902_MyFirstMigration")]
    partial class MyFirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiPreview_ThanhTan.Model.Books", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ApiPreview_ThanhTan.Model.Borrowings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("BooksID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LibraryCardsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BooksID");

                    b.HasIndex("LibraryCardsID");

                    b.ToTable("Borrowings");
                });

            modelBuilder.Entity("ApiPreview_ThanhTan.Model.LibraryCards", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("LibraryCards");
                });

            modelBuilder.Entity("ApiPreview_ThanhTan.Model.Borrowings", b =>
                {
                    b.HasOne("ApiPreview_ThanhTan.Model.Books", "Books")
                        .WithMany("borrowings")
                        .HasForeignKey("BooksID");

                    b.HasOne("ApiPreview_ThanhTan.Model.LibraryCards", "LibraryCards")
                        .WithMany("borrowings")
                        .HasForeignKey("LibraryCardsID");

                    b.Navigation("Books");

                    b.Navigation("LibraryCards");
                });

            modelBuilder.Entity("ApiPreview_ThanhTan.Model.Books", b =>
                {
                    b.Navigation("borrowings");
                });

            modelBuilder.Entity("ApiPreview_ThanhTan.Model.LibraryCards", b =>
                {
                    b.Navigation("borrowings");
                });
#pragma warning restore 612, 618
        }
    }
}
