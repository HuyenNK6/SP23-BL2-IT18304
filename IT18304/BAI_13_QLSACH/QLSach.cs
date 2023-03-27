using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_13_QLSACH
{
    internal class QLSach
    {
        //TOÀN CỤC
        //khởi tạo danh sách
        List<Sach> _lstSachs = new List<Sach>();
        //khai báo đối tượng
        Sach _sach; 
        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo đối tượng
                _sach = new Sach();
                //2. nhập thông tin đối tượng
                Console.WriteLine("Nhap ma: ");//string
                _sach.Ma = Console.ReadLine();
                Console.WriteLine("Nhap gia: ");//double
                _sach.Gia = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nhap nam sx: ");//int
                _sach.NamSX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap the loai (1-truyen, 2- SGK): ");//int
                _sach.TheLoai = Convert.ToInt32(Console.ReadLine());
                //3. thêm đối tượng vào danh sách
                _lstSachs.Add(_sach);
                //4. hỏi tiếp tục
                Console.WriteLine("To be continue khong ? (co/khong) ");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("co"));
            //Equals: so sánh = 2 chuỗi với nhau, có phân biệt hoa thường
        }
        public void XuatDS()
        {
            foreach (var item in _lstSachs)
            {
                item.InThongTin();
            }
        }
    }
}
/*
 * BTVN
 * tạo các class dưới đây và thực hiện TƯƠNG TỰ như bài học trên
 * Bài 1. Hoa
 * - id: int
 * - ten: string
 * - mauSac: string
 * - isReal: bool // thật or fake
 * Bài 2. TiVi
 * - ma: string
 * - hang: string
 * - inch: int
 * - namSX: int
 * - gia: double
 * - isVN: bool// hàng việt hay hàng ngoại
 */
