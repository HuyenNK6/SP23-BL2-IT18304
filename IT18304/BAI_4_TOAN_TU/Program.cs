using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_TOAN_TU
{
    internal class Program
    { /*
         * 4 Loại toán tử trong lập trình
         *  1. Toán tử số học:
         *  (+ - * / % ++ --)
         *      +: Tính tổng của 2 số hoặc dùng để cộng chuỗi
         *      -: Phép trừ của 2 số
         *      *: Phép nhân của 2 số
         *      %: Phép chia lấy dư của 2 số
         *      ++: Tăng lên 1 đơn vị
         *      --: Giảm 1 đơn vị
         *  2. Toán tử so sánh:
         *  (> < >= <= == !=)
         *      >: Lớn hơn
         *      <: nhỏ hơn
         *      >=: lớn hơn hoặc bằng
         *      <=: nhỏ hơn hoặc bằng
         *      ==: so sánh bằng
         *      !=: so sánh khác
         *  3. Toán tử Logic:
         * (&& || !)
         *      &&: Yêu cầu các mệnh đề phải luôn đúng
         *      ||: Yêu cầu 1 trong các mệnh đề dúng là được
         *      !: Lấy giá trị phủ định của mệnh đề.
         *  4. Toán tử gán:
         * (= += -= *= /= %=)
         *      +=: Cộng tiếp với vế bên phải các phép còn lại tương tự
         */

        /*
         * Toán tử ba ngôi
         *  <biểu thức> ? <kết quả đúng> : <kết quả sai>
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

         


            //nhập xuất thông tin chai nước
            //ma: string
            //hang: string
            //gia: double
            //namSX: int
            //isConHan: bool //true- còn hạn, false- hết hạn
            //cw tab
            Console.WriteLine("----Nhập-----");
            //ma: string
            Console.Write("Nhập mã: ");
            string ma = Console.ReadLine();
            //hang: string
            Console.Write("Nhập hãng: ");
            string hang= Console.ReadLine();
            //gia: double
            Console.Write("Nhập giá: ");
            double gia= Convert.ToDouble(Console.ReadLine());
            //namSX: int
            Console.Write("Nhập năm sx: ");
            int namSX= Convert.ToInt32(Console.ReadLine());
            //isConHan: bool
            Console.WriteLine("Còn hay hết hạn (true/false)? ");
            bool isConHan= Convert.ToBoolean(Console.ReadLine());

            //nếu có thể => toán tử 3 ngôi
            Console.WriteLine("----Xuất-----");
            Console.WriteLine($"ma= {ma}");
            Console.WriteLine($"hang= {hang}");
            Console.WriteLine($"gia= {gia}");
            Console.WriteLine($"namSX= {namSX}");
            Console.WriteLine($"isConHan= {isConHan}");
            Console.WriteLine($"isConHan= {( isConHan==true ?"Còn hạn" : "Hết hạn" )}");

            //sử dụng câu lệnh if else => còn hay hết hạn
            // (isConHan) => (isConHan == true)
            // (!isConHan) => (isConHan == false)
            
            if (!isConHan)
            {
                Console.WriteLine("Hết hạn");
            }
            else
            {
                Console.WriteLine("Còn hạn");
            }
            //////////////
            Console.WriteLine("Nhap 1 chuoi bat ky: ");
            int input = Console.Read();
            Console.WriteLine(input);
        }
    }
}
