﻿namespace TestPJ.Models
{
    public class SanPham
    {
        public int Id { get; set; }
        public string TenSP { get; set; }
        public double DonGia { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public string TrangThai { get; set; }
        public int SoLuong { get; set; }
        public int IdLoaiSP { get; set; }
    }
}