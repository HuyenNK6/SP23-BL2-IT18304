using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_18_De_Thi_So_1
{
    internal class QLSV
    {
        List<SinhVien> _lstSVs = new List<SinhVien>();
        SinhVien _sv;
        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo đt
                _sv = new SinhVien();
                //2. nhập tt
                Console.WriteLine("Nhap msv: ");
                _sv.Msv = Console.ReadLine();
                Console.WriteLine("Nhap ten: ");
                _sv.Ten = Console.ReadLine();
                Console.WriteLine("Nhap nam sinh: ");
                _sv.NamSinh = Convert.ToInt32(Console.ReadLine());
                //3.thêm đối tượng vào ds
                _lstSVs.Add(_sv);
                //4. hỏi
                Console.WriteLine("Co muon tiep tuc ko ? ");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("co"));
        }
        public void XuatDS()
        {
            if (_lstSVs.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!!");
                return;
            }
            foreach (var item in _lstSVs)
            {
                item.InThongTin();
            }
        }
        //BT: trả về 1 List<SinhVien>
        public void XuatDSTheoTuoi()
        {
            bool check = false;
            int count = 0; //cach 2
            for (int i = 0; i < _lstSVs.Count; i++)
            {
                if (_lstSVs[i].GetTuoi() > 20)
                {
                    _lstSVs[i].InThongTin();
                    check = true;
                    count++;//cách 2
                }
            }
            if (!check)
            {
                Console.WriteLine("khong tim thay!!!!");
            }
            if (count == 0)
            {
                Console.WriteLine("khong tim thay!!!!");
            }
        }
        public void TimKiemTheoMa()
        {
            Console.WriteLine("Nhap ma can tim: ");
            string ma = Console.ReadLine();
            for (int i = 0; i < _lstSVs.Count; i++)
            {
                if (_lstSVs[i].Msv.Equals(ma))
                {
                    Console.WriteLine("Da tim thay: ");
                    _lstSVs[i].InThongTin();
                    return;
                }
            }
            Console.WriteLine("Khong tim thay !!!!!!!!");
        }
        public void KeThua()
        {
            SinhVienUDPM svud = new SinhVienUDPM("Ph123", "Huyen", 2004, 7, 8);
            svud.InThongTin();

            _sv = new SinhVienUDPM("Ph123", "Huyen", 2004, 7, 8);
            _sv.InThongTin();
        }
    }
}
