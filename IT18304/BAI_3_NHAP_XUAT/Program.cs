using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_NHAP_XUAT
{
    internal class Program
    {
        /*
         * BÀI 1.2 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //PHẦN 1: NHẬP
            Console.WriteLine("Nhập thông tin SV");
            // Console.ReadLine(): đọc 1 dòng dữ liệu từ bàn phím
            // =>  Console.ReadLine() trả về kiểu dữ liệu là STRING

            //msv: string
            Console.WriteLine("Nhập msv: ");
            string msv = Console.ReadLine();
            //hoTen: string
            Console.WriteLine("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            //namSinh: int
            Console.WriteLine("Nhập năm sinh: ");
            //Console.ReadLine() => string
            //ép kiểu từ String về int
            int namSinh = Convert.ToInt32(Console.ReadLine());
            //diem: double
            Console.WriteLine("Nhập điểm: ");
            double diem  = Convert.ToDouble(Console.ReadLine());
            //isHocLai: bool => true- học lại, false- học đi
            Console.WriteLine("Học lại- true hay học đi- false? ");
            bool isHocLai= Convert.ToBoolean(Console.ReadLine());

            //PHẦN 2: XUẤT
            Console.WriteLine("Xuất thông tin SV");
            Console.WriteLine($"msv= {msv}");
            Console.WriteLine($"hoTen= {hoTen}");
            Console.WriteLine($"tuoi= {2023-namSinh}");
            Console.WriteLine($"diem= {diem}");
            Console.WriteLine($"isHocLai= {isHocLai}");
        }
    }
}
/*BTVN: 
 * nhập & xuất thông tin món quà 8/3 tặng NY
 * tenQua: string
 * giaTien: double
 * soLuong: int
 * xuatXu: string
 * isNew: bool -> true: mới, false- cũ
 */
