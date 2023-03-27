using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_12_LIST_OOP
{
    internal class OTO
    {
        //1. thuộc tính
        private int id;
        private string name;
        private int namSX;

        //2. constructor
        public OTO()
        {

        }

        public OTO(int id, string name, int namSX)
        {
            this.id = id;
            this.name = name;
            this.namSX = namSX;
        }
        //3. properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NamSX { get => namSX; set => namSX = value; }
        
        //4. InThongTin()
        public void InThongTin()
        {
            Console.WriteLine($"OTO: {id}| {name}| {namSX}");
        }

    }
}
