using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_15_QLTS
{
    internal class QLTS
    {
        List<TraSua> _lstTraSuas = new List<TraSua>();
        TraSua _traSua;
        public QLTS()
        {
            FakeData();
        }
        public void FakeData()
        {
            _lstTraSuas.Add(new TraSua("TS1","Toco","matcha", 30,1));
            _lstTraSuas.Add(new TraSua("TS2","Toco","matcha", 20,2));
            _lstTraSuas.Add(new TraSua("TS3","Toco","matcha", 10,2));
            _lstTraSuas.Add(new TraSua("TS4","Toco","matcha", 70,1));
            _lstTraSuas.Add(new TraSua("TS5","Toco","matcha", 50,1));
        }
        public void NhapDS()
        {
            string tiep_tuc;
            do
            {
                _traSua = new TraSua();

                Console.WriteLine("Nhap ma: ");
                _traSua.Ma = Console.ReadLine();
                Console.WriteLine("Nhap hang: ");
                _traSua.Hang = Console.ReadLine();
                Console.WriteLine("Nhap vi: ");
                _traSua.Vi = Console.ReadLine();
                Console.WriteLine("Nhap giam gia : ");
                _traSua.GiamGia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap size (1-Size M/2-Size L): ");
                _traSua.Size = Convert.ToInt32(Console.ReadLine());

                _lstTraSuas.Add(_traSua);
                Console.WriteLine("Co muon tiep tuc khong (co/khong):");
                tiep_tuc = Console.ReadLine();
            } while (tiep_tuc.Equals("co"));
        }
        public void XuatDS()
        {
            if (_lstTraSuas.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!");
                return;
            }
            Console.WriteLine("Danh sanh: ");
            foreach (var item in _lstTraSuas)
            {
                item.InThongTin();
            }
        }
        public void TimTraSuaTheoMa()
        {
   
        }  
        public void TimTheoGiamGia()
        {
   
        }
        public void Xoa()
        {
            Console.WriteLine("Nhap ma can xoa: ");
            string ma = Console.ReadLine();
            for (int i = 0; i < _lstTraSuas.Count; i++)
            {
                if (_lstTraSuas[i].Ma.Equals(ma))
                {
                    Console.WriteLine("Da tim thay: ");
                    _lstTraSuas[i].InThongTin();
                    _lstTraSuas.RemoveAt(i);
                    Console.WriteLine("Da xoa thanh cong");
                    return;
                }
            }
            Console.WriteLine("Khong tim thay!!!!!!!!");
        }
        public void SuaThongTin()
        {
            //sửa mức giảm giá
            Console.WriteLine("Nhap ma Tra sua can sua: ");
            string ma = Console.ReadLine();
            for (int i = 0; i < _lstTraSuas.Count; i++)
            {
                if (_lstTraSuas[i].Ma.Equals(ma))
                {
                    Console.WriteLine("Da tim thay: ");
                    _lstTraSuas[i].InThongTin();

                    Console.WriteLine("Nhap muc giam gia moi: ");
                    int giamGiaMoi = Convert.ToInt32(Console.ReadLine());

                    _lstTraSuas[i].GiamGia = giamGiaMoi;
                    Console.WriteLine("Sua thanh cong!");
                    return;
                }
            }
            Console.WriteLine("Khong tim thay!!!!!!");
        }
        public void SapXep()
        {//sắp xếp theo mức giảm giá
         //LINQ
         //Lambda Expression
         //Biểu Thức lambda:
         //Biểu thức Lambda là một cách ngắn hơn để biểu diễn phương thức ẩn danh.
         //cú pháp: parameters => body expressions (statements)
            Console.WriteLine("Sap xep Tang Dan");
            Console.WriteLine("Cach 1: ");//ko thay đổi ds gốc
            foreach (var item in _lstTraSuas.OrderBy(ts => ts.GiamGia))
            {
                item.InThongTin();
            }
            Console.WriteLine("Cach 2: ");//thay đổi ds gốc
            _lstTraSuas = _lstTraSuas.OrderBy(ts => ts.GiamGia).ToList();
            XuatDS();
            //////////////////////////
            Console.WriteLine("Sap xep Giam Dan");
            Console.WriteLine("Cach 1: ");//ko thay đổi ds gốc
            foreach (var item in _lstTraSuas.OrderByDescending(ts => ts.GiamGia))
            {
                item.InThongTin();
            }
            Console.WriteLine("Cach 2: ");//thay đổi ds gốc
            _lstTraSuas = _lstTraSuas.OrderByDescending(ts => ts.GiamGia).ToList();
            XuatDS();
        } 
    }
}
