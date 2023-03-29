using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_14_QLDH
{
    internal class DongHo
    {
        private int id;
        private string hang;
        private double gia;
        private bool isReal;//true- Real, false- Fake

        public DongHo()
        {

        }

        public DongHo(int id, string hang, double gia, bool isReal)
        {
            this.id = id;
            this.hang = hang;
            this.gia = gia;
            this.isReal = isReal;
        }

        public int Id { get => id; set => id = value; }
        public string Hang { get => hang; set => hang = value; }
        public double Gia { get => gia; set => gia = value; }
        public bool IsReal { get => isReal; set => isReal = value; }
    
        public void InThongTin()
        {
            Console.WriteLine($"DongHo:" +
                $"id= {id} | " +
                $"hang= {hang} | " +
                $"gia= {gia} | " +
                $"isReal= {KiemTra()}");
        }
        public string KiemTra()
        {
            if (isReal)
            {
                return "Hang real";
            }
            return "Hang fake";
        }
    }
}
