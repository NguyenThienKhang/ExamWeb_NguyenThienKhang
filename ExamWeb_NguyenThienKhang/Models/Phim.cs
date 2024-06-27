using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenThienKhang.Models
{
    public class Phim
    {
        public int Id { get; set; }
        [StringLength(250)]

        [Required(ErrorMessage ="Chưa nhập tựa đề")]
        public string TuaDe { get; set; }

        [StringLength(250)]

        [Required(ErrorMessage = "Chưa nhập tên điễn viên")]
        public string DienVien { get; set; }

        public bool TrongNuoc { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Giá vé phải là số không âm.")]
        public double GiaVe { get; set; }


        [Range(60, 180, ErrorMessage = "Thời gian từ 60 đến 180")]
        public int ThoiLuong { get; set; }

    }
}
