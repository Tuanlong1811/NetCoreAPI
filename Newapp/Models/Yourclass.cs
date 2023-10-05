using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {


Person ps = new Person();
Person ps2 = new Person();
ps.NhapThongTin();
ps.HienThi();
ps2.HienThi();
//nguyen tuan long-1721050348
Employee emp = new Employee();
emp.NhapThongTin();
emp.HienThi();
Student std = new Student();
std.NhapThongTin();
std.HienThi();

Fruit frt = new Fruit();
frt.NhapThongTin();
frt.HienThi();
    }

}