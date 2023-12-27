using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        [Required(ErrorMessage = "Makhachhang khong duoc de trong")]
        public required string MaKhachHang { get; set; }
        public required string TenKhachHang { get; set; }

        public int SDTKhachHang { get; set; }
        public required string DiaChiKhachHang { get; set; }

        
    }
}