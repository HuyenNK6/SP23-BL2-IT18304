using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_15_QLTS
{
    internal class TraSua
    {
        private string ma;
        private string hang;
        private string vi;
        private int giamGia;
        private int size;
        public TraSua()
        {

        }

        public TraSua(string ma, string hang, string vi, int giamGia, int size)
        {
            this.ma = ma;
            this.hang = hang;
            this.vi = vi;
            this.giamGia = giamGia;
            this.size = size;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Hang { get => hang; set => hang = value; }
        public string Vi { get => vi; set => vi = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public int Size { get => size; set => size = value; }

        public void InThongTin()
        {
            Console.WriteLine($"Ma: {ma} | " +
                $"Hang: {hang} | " +
                $"Vi: {vi} | " +
                $"Giam gia: {giamGia} | " +
                $"Size: {(size == 1 ? "Size M" : "Size L")} | ");
        }
    }
}
