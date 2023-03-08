using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_KHAI_BAO_BIEN
{
    internal class Program
    {
        /*
         * Bài 1.1 Khai báo biến
         * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến được khởi tạo trong bộ nhớ ảo khi chương trình khởi chạy.
         *
         * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
         *      Khai báo nhiều biến có cùng kiểu dữ liệu trên cùng 1 dòng:
         *      <Kiểu dữ liệu> <Tên Biến1> = <Giá trị>, <Tên Biến2> = <Giá trị>, <tên biến n>;
         * 1. <Kiểu dữ liệu> 
         *  + Số nguyên:sbyte, byte, long, int
         *  + Sô thực: float, double, decimal
         *  + Chuỗi hoặc ký tự: string, char
         *  + Logic: bool
         *  + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
         * 2. <Tên Biến>
         *  + Quy tắc:
         *      - Tên biến phải có nghĩa
         *      - Có phân biệt chữ hoa chữ thường
         *      - Không bắt đầu bởi số, không dùng từ khóa
         *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
         *  + Khai báo tên biến với 2 từ trở lên:
         *      - Cách 1: normal = firstname
         *      - Cách 2: CamelCase = FirstName, firstName
         *      - Cách 3: Under_Score = first_name, first_Name (hay còn gọi là snake_case)
         *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
         *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
         *      - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến.
         *      - int _year = 1989;
         * 3.<Giá trị>
         *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
         *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
         *
         */
        //biến toàn cục
        static int _namSinh = 2004;
        static void Main(string[] args)
        {
            //gõ được tiếng việt
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //biến cục bộ
            int a;
            int b = 5;

            double diem = 8.2;
            float chieuCao = 152;
            float canNang = 40.5f;

            char c = 'H';
            //char[] hoTen;
            string hoTen = "Khánh Huyền";

            bool isBoy = true; //true- nam, false- nữ

            var v1 = 50;
            var v2 = false;
            var v3 = "FPT";
            //var v4; => phải khởi tạo gtri luôn
            Console.WriteLine(hoTen);
            Console.WriteLine("Tên tôi là: "+ hoTen+ " cao: "+ chieuCao);
            Console.WriteLine($"Tên tôi là: {hoTen} cao {chieuCao}");
            Console.WriteLine($"Tuổi là: {2023- _namSinh}");

        }
    }
}
