﻿﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace MvcMovie.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241001070952_Create_table_Person")]
    partial class Create_table_Person
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MvcMovie.Models.Entities.Person", b =>
                {
                    b.Property<string>("CanCuocCongDan")
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CanCuocCongDan");

                    b.ToTable("Person");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("MvcMovie.Models.Entities.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("MvcMovie.Models.Entities.Employee", b =>
                {
                    b.HasBaseType("MvcMovie.Models.Entities.Person");

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ThoiGianLamViec")
                        .HasColumnType("TEXT");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("MvcMovie.Models.Entities.Employee", b =>
                {
                    b.HasOne("MvcMovie.Models.Entities.Person", null)
                        .WithOne()
                        .HasForeignKey("MvcMovie.Models.Entities.Employee", "CanCuocCongDan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}