using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_18_De_Thi_So_1
{
    internal class SinhVienUDPM : SinhVien
    {
        private double diemJava;
        private double diemCSharp;

        public SinhVienUDPM()
        {

        }

        public SinhVienUDPM(string msv, string ten, int namSinh, double diemJava, double diemCSharp) : base(msv, ten, namSinh)
        {
            this.diemJava = diemJava;
            this.diemCSharp = diemCSharp;
        }

        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCSharp { get => diemCSharp; set => diemCSharp = value; }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"SV UDPM: {diemJava}| {diemCSharp}");
        }
    }
}
