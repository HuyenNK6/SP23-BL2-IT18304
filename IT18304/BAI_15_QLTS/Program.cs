using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_15_QLTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int choice;
            QLTS ql = new QLTS();
            do
            {
                Console.WriteLine("----------Menu----------");
                Console.WriteLine("1. Nhap danh sach doi tuong");
                Console.WriteLine("2. Xuat danh sach doi tuong");
                Console.WriteLine("3. Tim tra sua theo ma");
                Console.WriteLine("4. Tim tra sua co muc giam gia lon hon 30%");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("------------------------");
                Console.Write("Moi chon chuc nang (0-4): ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Nhap danh sach doi tuong");
                        ql.NhapDS();
                        break;
                    case 2:
                        Console.WriteLine("2. Xuat danh sach doi tuong");
                        ql.XuatDS();
                        break ;
                    case 3:
                        Console.WriteLine("3. Tim tra sua theo ma");
                        break;
                    case 4:
                        Console.WriteLine("4. Tim tra sua co muc giam gia lon hon 30%");
                        break; 
                    case 5:
                        Console.WriteLine("5. Xóa ");
                        ql.Xoa();
                        break;
                    case 6:
                        Console.WriteLine("6. Sua");
                        ql.SuaThongTin();
                        break;
                    case 7:
                        Console.WriteLine("7. Sap Xep");
                        ql.SapXep();
                        break;
                    case 0:
                        Console.WriteLine("Thoat...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Moi nhap lai chuc nang (0-4)!!!");
                        break;
                }
            } while (choice != 0);
        }
    }
}
