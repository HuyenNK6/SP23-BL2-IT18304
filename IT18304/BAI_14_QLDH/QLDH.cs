using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_QLDH
{
    internal class QLDH
    {
        //List<DongHo> _lstDongHos= new List<DongHo>();
        List<DongHo> _lstDongHos;
        DongHo _dongHo;

        //ctor tab -> constructor -> hàm tạo
        public QLDH()
        {
            _lstDongHos = new List<DongHo>();
            FakeData();
        }
        public void FakeData()
        {
            _lstDongHos.Add(new DongHo(1, "Apple", 10, true));
            _lstDongHos.Add(new DongHo(2, "ROLEX", 80, false));
            _lstDongHos.Add(new DongHo(3, "Casio", 20, true));
            _lstDongHos.Add(new DongHo(4, "Siu nhan", 50, false));
            _lstDongHos.Add(new DongHo(5, "Cute", 40, true));
            _lstDongHos.Add(new DongHo(6, "Apple", 100, true));
        }

        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                //1. khởi tạo đối tượng
                _dongHo = new DongHo();
                //2. nhập thông tin
                Console.WriteLine("Nhap id= ");
                _dongHo.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap hang= ");
                _dongHo.Hang = Console.ReadLine();
                Console.WriteLine("Nhap gia= ");
                _dongHo.Gia = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hang real dung k (true/false)? ");
                _dongHo.IsReal = Convert.ToBoolean(Console.ReadLine());
                //3. thêm đối tượng vào danh sách
                _lstDongHos.Add(_dongHo);
                //4. hỏi tiếp tục
                Console.WriteLine("Co muon tiep tuc k (yes/no)? ");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("yes"));

        }
        public void XuatDS()
        {
            if(_lstDongHos.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!!");
                return;
            }
            foreach (var item in _lstDongHos)
            {
                item.InThongTin();
            }
        }

        public void TimKiemTheoId()
        {
            //1 kết quả
            Console.WriteLine("Nhap nhap id can tim: ");
            int id = Convert.ToInt32(Console.ReadLine());
            //cách 2: foreach
            for (int i = 0; i < _lstDongHos.Count; i++)
            {
                if (_lstDongHos[i].Id == id)
                {
                    Console.WriteLine("Da tim thay: ");
                    _lstDongHos[i].InThongTin();
                    return; //tìm thấy và thoát luôn
                }
            }
            Console.WriteLine("Khong tim thay!!!!!");
        }
        public void TimKiemTheoKhoang()
        {
            //nhiều kết quả
            //tìm kiếm theo khoảng giá => min - max
            Console.WriteLine("Nhap gia min: ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap gia max: ");
            double max = Convert.ToDouble(Console.ReadLine());

            bool check = false;
            //int count = 0;
            for (int i = 0; i < _lstDongHos.Count; i++)
            {
                if (_lstDongHos[i].Gia >= min &&
                        _lstDongHos[i].Gia <= max)
                {
                    _lstDongHos[i].InThongTin();
                    check = true;//nếu tìm thấy
                    //count++;
                }
            }
            if (!check)
            {//if (!check) <=> if (check == false)
                Console.WriteLine("Khong tim thay!!!");
            }
        }
    }
}
