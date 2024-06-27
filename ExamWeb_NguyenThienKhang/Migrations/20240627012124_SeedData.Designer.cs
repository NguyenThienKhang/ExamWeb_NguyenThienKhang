﻿// <auto-generated />
using ExamWeb_NguyenThienKhang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamWeb_NguyenThienKhang.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240627012124_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamWeb_NguyenThienKhang.Models.Phim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DienVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GiaVe")
                        .HasColumnType("float");

                    b.Property<int>("ThoiLuong")
                        .HasColumnType("int");

                    b.Property<bool>("TrongNuoc")
                        .HasColumnType("bit");

                    b.Property<string>("TuaDe")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("phims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DienVien = "Khang",
                            GiaVe = 100000.0,
                            ThoiLuong = 100,
                            TrongNuoc = true,
                            TuaDe = "Chúng ta của 8 năm sau"
                        },
                        new
                        {
                            Id = 2,
                            DienVien = "Duy",
                            GiaVe = 200000.0,
                            ThoiLuong = 110,
                            TrongNuoc = false,
                            TuaDe = "Gặp em ngày nắng"
                        },
                        new
                        {
                            Id = 3,
                            DienVien = "Huân",
                            GiaVe = 500000.0,
                            ThoiLuong = 500,
                            TrongNuoc = true,
                            TuaDe = "Không ngạy cưới"
                        },
                        new
                        {
                            Id = 4,
                            DienVien = "Phát",
                            GiaVe = 900000.0,
                            ThoiLuong = 120,
                            TrongNuoc = false,
                            TuaDe = "Gia đình đại chiến"
                        },
                        new
                        {
                            Id = 5,
                            DienVien = "Nam",
                            GiaVe = 700000.0,
                            ThoiLuong = 250,
                            TrongNuoc = true,
                            TuaDe = "Tây du ký"
                        },
                        new
                        {
                            Id = 6,
                            DienVien = "Thông",
                            GiaVe = 600000.0,
                            ThoiLuong = 100,
                            TrongNuoc = true,
                            TuaDe = "Gián điệp"
                        },
                        new
                        {
                            Id = 7,
                            DienVien = "Tú",
                            GiaVe = 105000.0,
                            ThoiLuong = 100,
                            TrongNuoc = true,
                            TuaDe = "Cuộc chiến nhân tâm"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
