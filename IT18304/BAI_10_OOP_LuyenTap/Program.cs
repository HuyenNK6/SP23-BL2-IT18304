using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_10_OOP_LuyenTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. khởi tạo đối tượng = ctor có tham số
            DienThoai dt1 = new DienThoai("DT1", "iphone",16,14.3, false);

            //2. khởi tạo đối tượng = ctor ko tham số
            DienThoai dt2 = new DienThoai();
            dt2.Seri = "DT2";
            dt2.DungLuong = 32;
            dt2.PhienBan = 15;
            dt2.IsNew = true;

            //3. gọi phương thức in
            dt1.InThongTin();
            dt2.InThongTin();

            DienThoai dt3 = new DienThoai();
            //seri: string
            Console.WriteLine("Nhap seri= ");
            dt3.Seri = Console.ReadLine();
            //hang: string
            Console.WriteLine("Nhap hang= ");
            dt3.Hang = Console.ReadLine();
            //dungLuong: int
            Console.WriteLine("Nhap dung luong= ");
            dt3.DungLuong = Convert.ToInt32(Console.ReadLine());
            //phienBan: double
            Console.WriteLine("Nhap phien ban= ");
            dt3.PhienBan = Convert.ToDouble(Console.ReadLine());
            //isNew: bool
            Console.WriteLine("Con moi hay cu (true/false)? ");
            dt3.IsNew = Convert.ToBoolean(Console.ReadLine());
            //in
            dt3.InThongTin();

        }
    }
}
