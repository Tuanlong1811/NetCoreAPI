namespace NewApp.Models
{
    public class Person
    // nguyễn tuấn long-1721050348
    {
        //thuoc tinh
       public string PersonID { get; set; }
       public string FullName { get; set; }
       public int Age { get; set; }
       
       //phuong thuc
       public void NhapThongTin()
       {
        System.Console.Write("PersonID = ");
        PersonID = Console.ReadLine();
        System.Console.Write("Full Name = ");
        FullName = Console.ReadLine();
        System.Console.Write("Age = ");
        // try... catch
        try{
            //câu lệnh có thể gây ngoại lệ
            Age = Convert.ToInt16(Console.ReadLine());
        }catch(Exception e)
        {
            //câu lệnh xử lý ngoại lệ
            Age = 0;
        }
       }
       public void HienThi()
       {
        System.Console.WriteLine("{0} - {1} - {2} tuoi", PersonID, FullName, Age);
       }
    }
}
