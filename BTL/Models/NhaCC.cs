using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTL.Models
{
    [Table("NhaCC")]
    public class NhaCC
    {
        [Key]
        public required string NhaCCID { get; set; }
        public required string TenNhaCC { get; set; }
        public required string TenSPCC { get; set; }
        public int SoLuongCC { get; set; }
        public int GiaThanh { get; set; }
        public required string DiaChi { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



    }
}