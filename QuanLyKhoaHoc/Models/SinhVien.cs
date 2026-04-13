using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyKhoaHoc.Models
{
    public class SinhVien
    {
        [Key]
        public int MaSV { get; set; }
        [Required]
        public string HoTen { get; set; }
        public ICollection<DangKy> DangKys { get; set; }
    }
}