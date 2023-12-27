using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    [Table("HoaDon")]

    public class HoaDon
    {
        [Key]
        public required string TenSP { get; set; }
        public int SoLuongSP { get; set; }
        public int ThanhTien { get; set; }
         [DataType(DataType.Date)]
        public DateTime Ngayban { get; set; }

        
    }
}