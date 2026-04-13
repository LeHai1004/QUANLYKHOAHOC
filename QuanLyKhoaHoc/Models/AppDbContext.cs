using Microsoft.EntityFrameworkCore;

namespace QuanLyKhoaHoc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<DangKy> DangKys { get; set; }
    }
}