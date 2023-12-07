using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetMVC.Models
{
    [Table("Khachhang")]
    public class Khachhang
    {
        [Key]
        public string KhachhangID { get; set; }
        public string Tenkhachhang { get; set; }
        public int SDTkhachang { get; set; }
        public string Diachi { get; set; }
    }
}