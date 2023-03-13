using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_6_MENU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.WriteLine("To be continue......");
        }
        static void Menu()
        {
            int chon;
            //do tab
            do
            {
                Console.WriteLine("----------MENU------");
                Console.WriteLine("---1. Bai 1     ----");
                Console.WriteLine("---2. Bai 2     ----");
                Console.WriteLine("---3. Bai 3     ----");
                Console.WriteLine("---0. Thoat     ----");
                Console.WriteLine("--------------------");
                Console.WriteLine("Moi may chon chuc nang: ");
                chon = Convert.ToInt32(Console.ReadLine());
                //sw tab
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("---1. Bai 1     ----");
                        break;
                    case 2:
                        Console.WriteLine("---2. Bai 2     ----");
                        break;
                    case 3:
                        Console.WriteLine("---3. Bai 3     ----");
                        break;
                    case 0:
                        Console.WriteLine("---0. Thoat CT     ----");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhap lai!!!!!!!!!!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
