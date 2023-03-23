using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_9_OOP
{
    internal class SinhVien
    {
        //1. thuộc tính
        //private tất cả thuộc tính => t/c đóng gói
        private string msv;
        private string hoTen;
        private int namSinh;
        private double diem;
        private bool isBoy;
        //2. constructor - hàm tạo
        //2.1 constructor không tham số
        //ctor tab
        public SinhVien()
        {

        }
        //2.2 constructor có tham số
        //bôi đen tất cả thuộc tính
        //click chuột phải => Quick Action...
        //Generate constructor...
        public SinhVien(string msv, string hoTen, int namSinh, double diem, bool isBoy)
        {
            this.msv = msv;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diem = diem;
            this.isBoy = isBoy;
        }
        //3. Properties
        //bôi đen tất cả thuộc tính
        //click chuột phải => Quick Action...
        //Encapsulate Field...
        public string Msv { get => msv; set => msv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }
        public bool IsBoy { get => isBoy; set => isBoy = value; }

        //4. phương thức InThongTin()
        public void InThongTin()
        {
            Console.WriteLine($"SinhVien: " +
                $"msv= {msv}| " +
                $"hoTen= {hoTen}|" +
                $"namSinh= {namSinh}| " +
                $"diem= {diem}| " +
                $"isBoy= {isBoy}");
        }
    }
}
