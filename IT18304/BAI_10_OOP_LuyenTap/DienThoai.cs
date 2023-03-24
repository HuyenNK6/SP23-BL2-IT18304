using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_10_OOP_LuyenTap
{
    internal class DienThoai
    {
        //1. thuộc tính
        private string seri;
        private string hang;
        private int dungLuong;
        private double phienBan;
        private bool isNew; //true-mới, false-cũ
         //2. constructor
             //2.1 ctor ko tham số
        public DienThoai()
        {
            hang = "iphone";
            Console.WriteLine("Day la Dien thoai");
        }
        //2.2 ctor có tham số
        public DienThoai(string seri, string hang, int dungLuong, double phienBan, bool isNew)
        {
            this.Seri = seri;
            this.Hang = hang;
            this.DungLuong = dungLuong;
            this.PhienBan = phienBan;
            this.IsNew = isNew;
        }
        //3. properties
        public string Seri { get => seri; set => seri = value; }
        public string Hang { get => hang; set => hang = value; }
        public int DungLuong { get => dungLuong; set => dungLuong = value; }
        public double PhienBan { get => phienBan; set => phienBan = value; }
        public bool IsNew { get => isNew; set => isNew = value; }

        //4. Phương thức InThongTin()
        public void InThongTin()
        {
            Console.WriteLine($"DienThoai: " +
                $"seri = {seri} | " +
                $"hang = {hang} | " +
                $"dungLuong= {dungLuong} | " +
                $"phienBan= {phienBan} | " +
                $"isNew= { (isNew ? "MOI" : "CU") } | " +
                $"trangThai = {GetTrangThai()}");
        }
        public string GetTrangThai()
        {
            if ( !isNew )
            {
                return "CU";
            }
            return "MOI";
        }
    }
}
