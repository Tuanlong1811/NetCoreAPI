using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    [Table("KhoHang")]

    public class KhoHang 
    {
        [Key]
        public  string MaSP { get; set; }
       
        public  string TenSP { get; set; }
       
       
        public  string GiaSP { get; set; }
        
       
        public  string SoLuongSP { get; set; }
        
    }
}