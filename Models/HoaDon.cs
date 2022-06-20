using System;

namespace TestPJ.Models
{
    public class HoaDon
    {
        public int Id { get; set; }
        public int IdKH { get; set; }
        public DateTime NgayXuat { get; set; }       
        public string TrangThai { get; set; }
        public double TongTien { get; set; }
    }
}
