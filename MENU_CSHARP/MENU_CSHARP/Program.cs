using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
            Console.WriteLine("to be continue.....");
        }
        static void Menu()
        {
            //do tab
            int chon;
            do
            {
                Console.WriteLine("--------MENU NỐI LẠI TÌNH XƯA--------");
                Console.WriteLine("1. Thông tin quán ăn");
                Console.WriteLine("2. Tinh chi phi đi lai");
                Console.WriteLine("3. Nhập mảng món ăn");
                Console.WriteLine("4. Tính tiền ăn");
                Console.WriteLine("0. Thoát CT");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Chọn chức năng: ");
                chon = Convert.ToInt32(Console.ReadLine());
                //sw tab
                switch (chon)
                {
                    case 1:
                        NhapThongTinQuan();
                        break;
                    case 2:
                        double chiPhi = TinhChiPhiDiLai();
                        Console.WriteLine($"Chi phí hết {chiPhi}");
                        break;
                    case 3:
                        Console.WriteLine("Em muốn ăn bao nhiêu món? ");
                        int soLuong = Convert.ToInt32(Console.ReadLine());
                        NhapMangMonAn(soLuong);
                        break;
                    case 4:
                        Console.WriteLine("Mấy người trả tiền? ");
                        int soNguoi = Convert.ToInt32(Console.ReadLine());
                        int tienAn= TinhTienAn(soNguoi);
                        Console.WriteLine($"Mỗi người phải trả {tienAn}");
                        break;
                    case 0:
                        Console.WriteLine("Thoát CT");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Mời bạn chọn lại!!!!");
                        break;
                }
            } while (chon != 0);
        }
        //1. hàm không trả về- không có tham số
        static void NhapThongTinQuan()
        {
            Console.WriteLine("Nhập tên quán ăn: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ quán: ");
            string diaChi= Console.ReadLine();
            Console.WriteLine("Đánh giá: ");
            int sao= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("THÔNG TIN QUÁN");
            Console.WriteLine($"Tên: {ten}");
            Console.WriteLine($"Địa chỉ: {diaChi}");
            Console.WriteLine($"Sao: {sao}");
        }
        //2. hàm có trả về- không có tham số
        static double TinhChiPhiDiLai()
        {
            Console.WriteLine("Nhập số km= ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập giá tiền/km= ");
            double gia= Convert.ToDouble(Console.ReadLine());
            return km * gia;
        }
        //3. hàm không trả về- có tham số
        static void NhapMangMonAn(int soLuong)
        {
            if(soLuong <= 0)
            {
                Console.WriteLine("Ăn gì cũng được!!");
                return;
            }
            string[] arrMonAns= new string[soLuong];
            //for tab
            Console.WriteLine("-----NHẬP MẢNG----");
            for (int i = 0; i < arrMonAns.Length; i++)
            {
                Console.WriteLine($"Nhập tên món ăn thứ {i+1}: ");
                arrMonAns[i] = Console.ReadLine();
            }
            Console.WriteLine("------XUẤT MẢNG----");
            //fore tab
            Console.WriteLine("Mời em xơi:");
            foreach (var item in arrMonAns)
            {
                Console.Write(item+"; ");
            }

        }
        //3. hàm có trả về- có tham số
        static int TinhTienAn(int soNguoi)
        {
            Console.WriteLine("Nhập số tiền ăn: ");
            int tienAn = Convert.ToInt32(Console.ReadLine());
            return tienAn / soNguoi;
        }

    }
}
