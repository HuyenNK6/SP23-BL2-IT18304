using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12_LIST_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. khởi tạo 1 danh sách list
            List <OTO> lstOTOs = new List <OTO>();
            //2. khởi tạo đối tượng -> ctrl D
            OTO o1 = new OTO(1, "mec", 2030);
            OTO o2 = new OTO(2, "mec", 2030);
            OTO o3 = new OTO(3, "mec", 2030);
            OTO o4 = new OTO(4, "mec", 2030);
            OTO o5 = new OTO(5, "mec", 2030);
            OTO o6 = new OTO(6, "mec", 2030);
            OTO o7 = new OTO(7, "mec", 2030);
            OTO o8 = new OTO(8, "mec", 2030);
            //3. thêm đối tượng vào danh sách
            lstOTOs.Add(o1);
            lstOTOs.Add(o2);
            lstOTOs.Add(o3);
            lstOTOs.Add(o4);
            lstOTOs.Add(o5);
            lstOTOs.Add(o6);
            lstOTOs.Add(o7);
            lstOTOs.Add(o8);
            //4. duyệt danh sách
            Console.WriteLine("Cach 1");
            for (int i = 0; i < lstOTOs.Count; i++)
            {
                lstOTOs[i].InThongTin();
                //lstOTOs[i]: đối tượng OTO tại vị trí i trong list
            }
            Console.WriteLine("Cach 2");
            foreach (var item in lstOTOs)
            {
                item.InThongTin();
            }
        }
    }
}
