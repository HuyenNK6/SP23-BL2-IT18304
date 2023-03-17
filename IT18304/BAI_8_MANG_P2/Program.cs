using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_8_MANG_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //nhập và xuất 1 mảng sỹ số các phòng học
            //tại tầng 4 tòa P
            Console.WriteLine("------------Nhập----------");
            //nếu số phòng <= 0 thì phải nhập lại
            int n;
            do
            {
                Console.WriteLine("Nhập số phòng tầng 4 tòa P: ");
                n = Convert.ToInt32(Console.ReadLine());
                if( n <= 0)
                {
                    Console.WriteLine("Nhập lại >0!!");
                }
            } while (n <= 0);


            //có bao nhiêu phòng thì có bấy nhiêu sỹ số
            //tạo 1 mảng sỹ số gồm có n phần tử
            int[] arrSySo = new int[n];
            for (int i = 0; i < arrSySo.Length; i++)
            {
                Console.WriteLine($"Nhập sỹ số phòng P40{i + 1}: ");
                arrSySo[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("------------Xuất----------");
            Console.WriteLine("Cách 1: for i");
            for (int i = 0; i < arrSySo.Length; i++)
            {
                Console.WriteLine($"Phòng P40{i + 1} có {arrSySo[i]}SV");
            }

            Console.WriteLine("Cách 2: foreach");
            //fore tab
            foreach (var item in arrSySo)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();//tạm dừng output
        }
    }
}
