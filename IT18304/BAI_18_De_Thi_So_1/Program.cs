using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAI_18_De_Thi_So_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            QLSV ql = new QLSV();
            int chon;
            do
            {
                Console.WriteLine("----------MENU---------");
                Console.WriteLine("1. Nhap DS");
                Console.WriteLine("2. Xuat DS");
                Console.WriteLine("3. Xuat DS Theo tuoi >20");
                Console.WriteLine("4. Tim kiem theo Ma");
                Console.WriteLine("5. Ke thua");
                Console.WriteLine("0. Thoat ct");
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
                        ql.XuatDSTheoTuoi();
                        break;
                    case 4:
                        ql.TimKiemTheoMa();
                        break;
                    case 5:
                        ql.KeThua();
                        break;
                    case 0:
                        break;

                    default:
                        break;
                }
            } while (chon != 0);
        }
    }
}
