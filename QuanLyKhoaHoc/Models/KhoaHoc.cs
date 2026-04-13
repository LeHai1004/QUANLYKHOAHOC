using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyKhoaHoc.Models
{
    public class KhoaHoc
    {
        [Key]
        public int MaKH { get; set; }
        [Required]
        public string TenKH { get; set; }
        public ICollection<DangKy> DangKys { get; set; }
    }
}