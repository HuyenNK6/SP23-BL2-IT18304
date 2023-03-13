using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_7_MANG
{
    internal class Program
    {
        /*
        * Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán.
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
        /*
       * Thao tác với mảng
       *  ***Phương thức của Array
       *      + SetValue(<giá trị>,<index>): Gán giá trị cho phần tử ở vị trí.
       *      + GetValue(index): lấy giá trị ở vị trí
       *      + IndexOf(<Array>,<value>): Tìm kiếm vị trí của phần tử
       *      + GetLength(0): Trả ra số lượng phần tử trong mảng
       *      + Reverse(<mảng>): Đảo ngược mảng
       *      + Sort(Array): Sắp xếp mảng

       */
        static void Main(string[] args)
        {
            //1. khai báo mảng
            //int arrSo[5];
            int[] arrSo;

            //2. khởi tạo mảng
            //arrSo = { 1,2,3};
            arrSo = new int[] { 1, 2, 3 };
            int[] arrNum1= { 1, 2, 3 };
            int[] arrNum2= new int[] { 4, 5, 6};

            //khai báo 1 mảng có kích thước gồm 5 phần tử
            //có 1 phần tử có giá trị 5
            int[] arrNum3 = new int[] { 5 };
            //kích thước gồm 5 phần tử
            int[] arrTuoi = new int[5];

            //3. gán giá trị
            //vị trí chạy từ  0- (n-1)
            arrTuoi[0] = 18;
            arrTuoi[1] = 25;
            arrTuoi[2] = 10;
            arrTuoi[3] = 9;
            arrTuoi[4] = 32;
            //arrTuoi[5] = 18;

            //4. truy xuất phần tử
            Console.WriteLine($"arrTuoi[1]= {arrTuoi[1]}");

            //5. duyệt mảng
            Console.WriteLine("Cach 1: for i");
            //for tab
            for (int i = 0; i < arrTuoi.Length; i++)
            {
                Console.WriteLine($"arrTuoi[{i}]= {arrTuoi[i]}");
            }

            Console.WriteLine("Cach 2: foreach");
            //fore tab
            foreach (var item in arrTuoi)
            {
                Console.WriteLine(item);
            }
            //////////////////////////
            string[] arrMonHoc = { "Java", "C#", "English", "Business"};
            double[] arrDiemTB = { 9.2, 5.6, 8.4, 10 };

            Console.WriteLine("C1: Mang mon hoc");
            Console.WriteLine($"length= {arrMonHoc.Length}");
            Array.Sort(arrMonHoc);
            Array.Reverse(arrMonHoc);
            for (int i = 0; i < arrMonHoc.Length; i++)
            {
                Console.WriteLine(arrMonHoc[i]);
            }

            Console.WriteLine("C2: Mang diem tb");
            Array.Sort(arrDiemTB);
            Array.Reverse(arrDiemTB);
            foreach (var item in arrDiemTB)
            {
                Console.WriteLine(item);
            }

        }
    }
}
