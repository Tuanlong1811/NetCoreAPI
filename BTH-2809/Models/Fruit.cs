namespace NewApp.Models
{
    public class Fruit
    {
        public string TenLoaiQua { get; set; }
        public int GiaSanPham { get; set; }
        public int KhoiLuong { get; set; }
        public void NhapThongTin()
        //nguyễn sỹ tiến - 2021050637
        {
            
           System.Console.Write("Ten Loai Qua = ");
           TenLoaiQua = Console.ReadLine();
           System.Console.Write("Gia San Pham = ");
           GiaSanPham = Convert.ToInt32(Console.ReadLine());
           System.Console.Write("Khoi Luong = ");
           KhoiLuong = Convert.ToInt32(Console.ReadLine());
           //try ... catch
           try{
           System.Console.Write("Gia San Pham = ");
           GiaSanPham = Convert.ToInt32(Console.ReadLine());
           }catch(Exception e)
           {
            System.Console.WriteLine("Co ngoai le xay ra");
           }
        }
        public void HienThi()
        {
            System.Console.WriteLine("{0} - {1} - {2} kg", TenLoaiQua, GiaSanPham, KhoiLuong);
        }
    }
}