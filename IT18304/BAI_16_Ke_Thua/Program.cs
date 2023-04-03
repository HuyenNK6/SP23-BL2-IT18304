using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_16_Ke_Thua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien("Long", 2004, 0, "PH123", 10);
            sv1.InThongTin();

            SinhVien sv2 = new SinhVien();
            sv2.Ten = "Thuy";
            sv2.NamSinh = 2005;
            sv2.GioiTinh = 1;
            sv2.Msv = "PH456";
            sv2.Diem = 7;

            sv2.InThongTin();


            Nguoi sv3 = new SinhVien("Long", 2004, 0, "PH123", 10);
            sv3.InThongTin();

            Nguoi sv4 = new SinhVien();
            Nguoi gv1 = new GiangVien();
        }
    }
}
