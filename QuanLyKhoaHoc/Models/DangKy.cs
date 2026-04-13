using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhoaHoc.Models
{
    public class DangKy
    {
        [Key]
        public int MaDK { get; set; }

        public int MaSV { get; set; }
        [ForeignKey("MaSV")]
        public SinhVien SinhVien { get; set; }

        public int MaKH { get; set; }
        [ForeignKey("MaKH")]
        public KhoaHoc KhoaHoc { get; set; }
    }
}