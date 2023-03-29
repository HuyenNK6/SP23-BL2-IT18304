using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_QLDH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            QLDH ql = new QLDH();
            int chon;
            do
            {
                Console.WriteLine("-------MENU-----");
                Console.WriteLine("1. Nhap DS");
                Console.WriteLine("2. Xuat DS");
                Console.WriteLine("3. Tim kiem theo id");
                Console.WriteLine("4. Tim kiem theo khoang");
                Console.WriteLine("0. Thoat CT");
                Console.WriteLine("------------------");
                Console.WriteLine("Moi chon: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;
                    case 2:
                        ql.XuatDS();
                        break; 
                    case 3:
                        ql.TimKiemTheoId();
                        break;
                    case 4:
                        ql.TimKiemTheoKhoang();
                        break;
                    case 0:
                        Console.WriteLine("Thoat CT...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhap lai!!!!!!!!!");
                        break;
                }
            } while (chon!=0);
        }
    }
}
