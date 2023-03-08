using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_EP_KIEU
{
    internal class Program
    {
        /*
        * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
        *
        * Công thức ép kiểu tường minh:
        *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
        *
        * P2: Ép kiểu từ string về số
        *  + Phương thức Parse()
        *  + Lớp Convert()
        */
        static void Main(string[] args)
        {
            //PHẦN 1: ÉP KIỂU GIỮA CÁC SỐ
            //ép kiểu ngầm định
            int a = 12;
            double b = a;
            //cw tab
            Console.WriteLine($"a= {a}");
            Console.WriteLine($"b= {b}");

            //ép kiểu tường minh
            double c = 9.3;
            int d = (int) c;
            Console.WriteLine($"c= {c}");
            Console.WriteLine($"d= {d}");

            //PHẦN 2: ÉP KIỂU từ STRING về SỐ
            string number1 = "8";
            string number2 = "10";
            Console.WriteLine(number1+ number2);

            //int.Parse => nếu string null => ArgumentNullException:
            int n1 = int.Parse(number1);
            //Convert.ToInt32 => nếu string là null 
            //=> nhận giá trị mặc định của kiểu dữ liệu vd =0
            int n2 = Convert.ToInt32(number2);

            Console.WriteLine($"n1= {n1}");
            Console.WriteLine($"n2= {n2}");

            Console.WriteLine(n1+ n2);

        }
    }
}
