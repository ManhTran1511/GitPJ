using System.Collections.Generic;

namespace TestPJ.Models
{
    public class LoaiSanPham
    {
        public int Id { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public ICollection<SanPham> SanPhams { get; set; }
    }
}
