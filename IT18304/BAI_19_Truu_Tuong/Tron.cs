using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_19_Truu_Tuong
{
    internal class Tron : Hinh
    {
        private double banKinh;
        public Tron()
        {

        }

        public Tron(string ten, double banKinh) : base(ten)
        {
            this.banKinh = banKinh;
        }

        public double BanKinh { get => banKinh; set => banKinh = value; }

        public override void InRaManHinh()
        {
            base.InRaManHinh();
            Console.WriteLine($"Hinh tron: banKinh= {banKinh}");
        }

        public override double tinhChuVi()
        {
            return 2 * 3.14 * banKinh;
        }

        public override double tinhDienTich()
        {
            return 3.14 * banKinh * banKinh;
        }
    }
}
