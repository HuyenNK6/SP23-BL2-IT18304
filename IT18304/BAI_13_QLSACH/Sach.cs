using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_13_QLSACH
{
    internal class Sach
    {
        private string ma;
        private double gia;
        private int namSX;
        private int theLoai; //1- truyen, 2-SGK
        // ctor tab
        public Sach()
        {

        }
        //bôi đen -> click -> quick -> gen...constructor...
        public Sach(string ma, double gia, int namSX, int theLoai)
        {
            this.ma = ma;
            this.gia = gia;
            this.namSX = namSX;
            this.theLoai = theLoai;
        }
        //properties
        public string Ma { get => ma; set => ma = value; }
        public double Gia { get => gia; set => gia = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        public int TheLoai { get => theLoai; set => theLoai = value; }
        
        //in
        public void InThongTin()
        {
            Console.WriteLine($"Sach: " +
                $"ma= {ma} | " +
                $"gia= {gia} | " +
                $"namSX= {namSX} | " +
                $"theLoai= { (theLoai == 1 ? "Truyen": "SGK") }");
        }

    }
}
