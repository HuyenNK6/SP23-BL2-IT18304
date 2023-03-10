using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_5_IF_ELSE_VONG_LAP
{
    internal class Program
    {
        /*
       * Bài Vòng lặp:
       *
       * Định nghĩa chung cho tất cả vòng lặp:
       * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
       *
       * Các loại vòng lặp: while, do..while, for, foreach
       *
       * Từ khóa sử dụng trong vòng lặp:
       *
       * break - ngắt vòng lặp
       * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
       *
       * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
       * + Cách dùng: wh + tab
       *
       * + Công thức:
       *  while (true)
          {
              //Thực thi 1 câu lệnh hoặc nhiều câu lệnh
          }
          Vòng lặp Do..While: Thực hiện hành động ít nhất là 1 lần. Điều kiện đề vòng lặp chạy giống như While(True).
         Cách gõ: do + tab

       Công thức:
         do {
                    //Thực hiện hành động ít nhất là 1 lần.
         } while (true);
      */
        static void Main(string[] args)
        {
            //1. Vòng FOR
            //for tab
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Nhap so luong n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac so chan");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //2. Vòng while
            int a = 0;
            //whi tab
            while( a < 10)
            {
                if(a == 6)
                {
                    Console.WriteLine("Co Huyen hien nhat BM "+a);
                    // break;
                    a++;
                    continue;
                }
                Console.WriteLine("Co Huyen Xinh Gai "+ a);
                a++;
            }
            //3. Vòng Do-While
            int b = 30;
            //do tab
            do
            {
                Console.WriteLine("Co Huyen de thuong "+ b);
                b++;
            } while (b < 15);
        }
    }
}
/*
      * Bài 1: Nhập và xuất thông tin Xe Máy
      * - id: int
      * - hang: string
      * - gia: double
      * - phanKhoi: int
      * - isVietNam: bool 
      * => yêu cầu in ra true là Xe Máy Việt Nam/ false là Xe Máy Nước Ngoài
      * 
      * Bài 2: Nhập min- max (int) từ bàn phím
      * - Nếu người dùng nhập min/max <0 yêu cầu nhập lại
      * - In ra tất cả các số lẻ trong khoảng min-max
      * - và đếm xem có bao nhiêu số lẻ đó
      */