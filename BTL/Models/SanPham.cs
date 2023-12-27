using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    [Table("SanPham")]

    public class SanPham
    {
        [Key]
        public int MaSP { get; set; }
        public string TenSP { get; set; }

        public int GiaSP { get; set; }

        public int SoLuongSP { get; set; }
        public string TinhTrangSP { get; set; }

        
    }
}