namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string DateOfBirth {get; set;}
        public string Address {get; set;}
        public int StudentID {get; set;}
        public string PhoneNumber {get; set;}

        
        //nguyễn sỹ tiến - 2021050637
        
        public void NhapThongTin()
        {
            System.Console.WriteLine("Ho Va Ten");
            Name = Console.ReadLine();
            System.Console.WriteLine("Ngay Thang Nam Sinh");
            DateOfBirth = Console.ReadLine();
            System.Console.WriteLine("Dia Chi");
            Address = Console.ReadLine();
            System.Console.WriteLine("Ma Sinh Vien");
            System.Console.WriteLine("So Dien Thoai");
            PhoneNumber = Console.ReadLine();
            // try..catch
            try{
                StudentID = Convert.ToInt16(Console.ReadLine());
            } catch(Exception e)
            {
                StudentID =0;
            }
            
        }

        public void HienThi()
         {
             System.Console.WriteLine("{0}-{1}-{2}", Name, DateOfBirth, Address, StudentID, PhoneNumber);
         }
 }

 }    