namespace NewApp.Models
{
    public class Employee
    {

       public int MaNhanVien { get; set; }
       public string TenNhanVien { get; set; }
       public int Tuoi { get; set; }
       public double Luong { get; set; }
       
// nguyễn sỹ tiến - 2021050637
       public void NhapThongTin()
       {
        System.Console.Write("Ma Nhan Vien = ");
        MaNhanVien = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Ten Nhan Vien = ");
        TenNhanVien = Console.ReadLine();
        System.Console.Write("Tuoi = ");
        Tuoi = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Luong = ");
        //try ...catch 
         try{
            //câu lệnh có thể gây ngoại lệ
            Luong = Convert.ToInt16(Console.ReadLine());
        }catch(Exception e)
        {
            //câu lệnh xử lý ngoại lệ
            Luong = 0;
        }

       }
       public void HienThi()
       {
        System.Console.WriteLine("{0} - {1} - {2} - {3} VND", MaNhanVien, TenNhanVien, Tuoi, Luong);
       }
    }
}