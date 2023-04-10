using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_19_Truu_Tuong
{
    /*
    * 1. Lớp cha abstract về bản chất vẫn là 1 lớp cha hoàn toàn bình thường như lớp cha đã học.
    * 2. Khi đã gọi là lớp abstract thì phải có phương thức abstract
    */
    internal abstract class Hinh
    {
        private string ten;

        public Hinh()
        {

        }
        public Hinh(string ten)
        {
            this.ten = ten;
        }
        public string Ten { get => ten; set => ten = value; }
        //virtual: cấp quyền kế thừa
        public virtual void InRaManHinh()
        {
            Console.WriteLine($"Hinh: ten= {ten}");
        }
        /*
         * Phương thức abstract
         * 1. Phương thức sẽ không có body code
         * 2. Phương thức vẫn tương tự như phương thức đã học nhưng có từ khóa abstract
         */
        public abstract double tinhChuVi();
        public abstract double tinhDienTich();

    }
}
