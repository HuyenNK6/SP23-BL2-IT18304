using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_16_Ke_Thua
{//LỚP CON
    //KẾ THỪA TỪ LỚP CHA => DẤU :
    internal class SinhVien : Nguoi
    {//THUỘC TÍNH & PT RIÊNG
        private string msv;
        private double diem;
        //Tính chất Đa Hình OOP
        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //-> bổ sung thêm thuộc tính -> bôi đen thuộc tính lớp con
        // -> click chuột phải -> Add parameters to constructor -> chọn cái 2...
        public SinhVien()
        {

        }

        public SinhVien(string ten, int namSinh, int gioiTinh, string msv, double diem) : base(ten, namSinh, gioiTinh)
        {
            this.msv = msv;
            this.diem = diem;
        }

        public string Msv { get => msv; set => msv = value; }
        public double Diem { get => diem; set => diem = value; }



        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa

        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con
        //có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.

        //Ghi đè phương thức InThongTin() của lớp cha
        ////click tên lớp con => Quick Action
        //Generate override => ..phương thức của lớp cha

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Sinh Vien: {msv}| {diem}");
        }

    }
}
