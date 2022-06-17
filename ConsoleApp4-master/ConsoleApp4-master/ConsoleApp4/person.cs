using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person

{
    internal class person
    {
        public person(string name, int year);


        public person() { }

        private string name;

        public string Name { get => name; set => name = value; }


      

        public override string ToString()
        {
            return $"Группа - Персона\n" +

             $"Тип - {Name}\n";


        }
    }
}
    