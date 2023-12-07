using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetMVC.Models
{
    [Table("Sanpham")]
    public class Sanpham
    {
        [Key]
        public string SanphamID { get; set; }
        public string Tensanpham { get; set; }
        public int Thuonghieu { get; set; }
        public string Soluong { get; set; }
    }
}