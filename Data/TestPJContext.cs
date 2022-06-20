using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestPJ.Models;

namespace TestPJ.Data
{
    public class TestPJContext : DbContext
    {
        public TestPJContext (DbContextOptions<TestPJContext> options)
            : base(options)
        {
        }

        public DbSet<TestPJ.Models.NhaMay> NhaMay { get; set; }

        public DbSet<TestPJ.Models.Kho> Kho { get; set; }

        public DbSet<TestPJ.Models.LoaiSanPham> LoaiSanPham { get; set; }

        public DbSet<TestPJ.Models.SanPham> SanPham { get; set; }

        public DbSet<TestPJ.Models.SanPhamKho> SanPhamKho { get; set; }

        public DbSet<TestPJ.Models.HoaDon> HoaDon { get; set; }

        public DbSet<TestPJ.Models.ChiTietHoaDon> ChiTietHoaDon { get; set; }

        public DbSet<TestPJ.Models.KhachHang> KhachHang { get; set; }
    }
}
