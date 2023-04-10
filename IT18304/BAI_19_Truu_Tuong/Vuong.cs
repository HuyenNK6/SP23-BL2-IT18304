using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_19_Truu_Tuong
{
    internal class Vuong : Hinh
    {
        private int canh;
        public Vuong()
        {

        }

        public Vuong(string ten, int canh) : base(ten)
        {
            this.canh = canh;
        }

        public override void InRaManHinh()
        {
            base.InRaManHinh();
        }

        public override double tinhChuVi()
        {
            return canh * 4;
        }

        public override double tinhDienTich()
        {
            return canh * canh;
        }
    }
}
