namespace TestPJ.Models
{
    public class ChiTietHoaDon
    {
        public int IdHoaDon { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public virtual SanPham SanPhams { get; set; }
        public virtual HoaDon HoaDons { get; set; }

    }
}
