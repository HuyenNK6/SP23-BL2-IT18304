using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_13_QLSACH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            QLSach ql = new QLSach();//khởi tạo đối tượng quản lý
            int chon;
            //do tab
            do
            {
                Console.WriteLine("------------MENU----------");
                Console.WriteLine("1. Nhap DS");
                Console.WriteLine("2. Xuat DS");
                Console.WriteLine("0. Thoat CT");
                Console.WriteLine("---------------------------");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;
                    case 2:
                        ql.XuatDS();
                        break;
                    case 0:
                        Console.WriteLine("Thoat CT...........");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Moi chon lai!!!!!!!");
                        break;
                }
            } while (chon!=0);
        }
    }
}
