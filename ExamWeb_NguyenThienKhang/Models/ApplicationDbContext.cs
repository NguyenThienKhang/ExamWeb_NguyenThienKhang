using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenThienKhang.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
base(options)
        {
        }
        public DbSet<Phim> phims { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Phim>().HasData(
        new Phim { Id = 1, TuaDe = "Chúng ta của 8 năm sau", DienVien = "Khang", TrongNuoc = true, GiaVe = 100000, ThoiLuong = 100 },
        new Phim { Id = 2, TuaDe = "Gặp em ngày nắng", DienVien = "Duy", TrongNuoc = false, GiaVe = 200000, ThoiLuong = 110 },
        new Phim { Id = 3, TuaDe = "Không ngạy cưới", DienVien = "Huân", TrongNuoc = true, GiaVe = 500000, ThoiLuong = 500 },
        new Phim { Id = 4, TuaDe = "Gia đình đại chiến", DienVien = "Phát", TrongNuoc = false, GiaVe = 900000, ThoiLuong = 120 },
        new Phim { Id = 5, TuaDe = "Tây du ký", DienVien = "Nam", TrongNuoc = true, GiaVe = 700000, ThoiLuong = 250 },
        new Phim { Id = 6, TuaDe = "Gián điệp", DienVien = "Thông", TrongNuoc = true, GiaVe = 600000, ThoiLuong = 100 },
        new Phim { Id = 7, TuaDe = "Cuộc chiến nhân tâm", DienVien = "Tú", TrongNuoc = true, GiaVe = 105000, ThoiLuong = 100 }

       );
        }
    }
}
