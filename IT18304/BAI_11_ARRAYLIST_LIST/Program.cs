using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_11_ARRAYLIST_LIST
{
    internal class Program
    {
        /*
        *  ArrayList
        *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                       danh sách các đối tượng theo kiểu mảng (truy
                       cập các phần tử bên trong thông qua chỉ số
                       index)
           Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                       linh hoạt và có thể tự điều chỉnh kích cỡ một
                       cách tự động.
           Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                       thêm thư viện System.Collections
           Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
        */

        /*
          * A. CÁC PHƯƠNG THỨC TRONG ArrayList
          * 1. Add(object Value): Thêm đối tượng vào cuối.
          * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
          * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
          * 4. Clear(): Xóa tất cả các phần tử.
          * 5. Clone(): Tạo 1 bản sao của danh sách đó.
          * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
          * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
          * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
          ....................................
         */
        /*
                 *  LIST trong C# Generic Collections nó dùng lưu trữ giống như ArrayList vê khái niệm.
                 *
                 *  1.Khai báo:
                 *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>();
                 *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>(size);//Khai báo kích thước định sẵn
                 */

        /*
         * A. CÁC PHƯƠNG THỨC TRONG List
         * 1. Add(object Value): Thêm đối tượng vào cuối.
         * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
         * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
         * 4. Clear(): Xóa tất cả các phần tử.
         * 5. Clone(): Tạo 1 bản sao của danh sách đó.
         * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
         * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
         * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
         *9.CopyTo(<tên mảng>,<index>): Thực hiện sao chép các phần tử List về mảng 1 chiều từ index của mảng
         * 10. Remove(<value>): Xóa value ở trong List
         *
         * Ngoài ra còn có thêm 1 số phương thức khác
         */
        static void Main(string[] args)
        {
            //1. khởi tạo arrLst
            ArrayList arrLstTuoi = new ArrayList();
            //2. thêm phần tử vào arrLst
            arrLstTuoi.Add(10);
            arrLstTuoi.Add(13);
            arrLstTuoi.Add(22);
            arrLstTuoi.Add(8);
            arrLstTuoi.Add(34);
            ///
            arrLstTuoi.Add("Huyen xinh gai");
            arrLstTuoi.Add(true);

            //3. truy xuất phần tử
            Console.WriteLine(arrLstTuoi[0]);
            Console.WriteLine(arrLstTuoi[1]);
            Console.WriteLine(arrLstTuoi[2]);

            //4. duyệt arrLst
            Console.WriteLine("Cach 1: for i");
            for (int i = 0; i < arrLstTuoi.Count; i++)
            {
                Console.WriteLine($"arrLstTuoi[{i}]= {arrLstTuoi[i]}");
            }
            Console.WriteLine("Cach 2: foreach");
            //fore tab
            foreach (var item in arrLstTuoi)
            {
                Console.WriteLine(item);
            }
            //////////////////
            //1. khởi tạo list
            List <string> lstTen= new List<string>();
            //2. thêm phần tử vào list
            lstTen.Add("Khoa");
            lstTen.Add("Khanh");
            lstTen.Add("Phong");
            lstTen.Add("Cong");
            //lstTen.Add(100);
            //lstTen.Add(true);

            //3. duyệt list
            Console.WriteLine("Cach 1------------");
            //sắp xếp tăng dần
            lstTen.Sort();

            for (int i = 0; i < lstTen.Count; i++)
            {
                Console.WriteLine($"lstTen[{i}]= {lstTen[i]}");
            }
            
            Console.WriteLine("Cach 2------------");
            //xóa phần tử tại vị trí i
            lstTen.RemoveAt(0);

            //tìm kiếm nhị phân -> vị trí
            int viTri= lstTen.BinarySearch("Khanh");
            Console.WriteLine("Tim thay Khanh tai vi tri= "+ viTri);

            //xóa phần tử
            lstTen.Remove("Khanh");
            //đảo ngược
            lstTen.Reverse();

            foreach (var item in lstTen)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count= "+ lstTen.Count);
            lstTen.Clear();
            Console.WriteLine("count= " + lstTen.Count);
            if(lstTen.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!");
            }
        }
    }
}
/*
 * BTVN
 * P1. Tạo class DieuHoa gồm các thuộc tính
 * - id: int
 * - ten: string
 * - congSuat: int
 * - gia: double
 * - trangThai: int (1- mới, 2-cũ)
 * => private tất cả thuộc tính, 
 * tạo constructor ko tham số và có tham số,
 * có đầy đủ properties, tạo phương thức InThongTin()

 * P2.
 * - tạo 2 đối tượng bằng ctor có tham số
 * - tạo 2 đối tượng bằng ctor không tham số -> nhập thông tin từ bàn phím
 * - sau đó in thông tin ra màn hình bằng phương thức InThongTin()
 */
