using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_18_De_Thi_So_1
{
    internal class SinhVien
    {
        private string msv;
        private string ten;
        private int namSinh;

        public SinhVien()
        {

        }

        public SinhVien(string msv, string ten, int namSinh)
        {
            this.msv = msv;
            this.ten = ten;
            this.namSinh = namSinh;
        }

        public string Msv { get => msv; set => msv = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
    
        public virtual void InThongTin()
        {
            Console.WriteLine($"Sinh Vien: {msv}| {ten}| {GetTuoi()}");
        }
        public int GetTuoi()
        {
            return DateTime.Now.Year - namSinh;
        }
    }
}
