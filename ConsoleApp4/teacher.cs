
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person 


{
    internal class teacher : person
    {
        public teacher(string name, int year, string exp);



        public teacher() { }

        private string name;
        private string exp;
        private int year;

        public string Name1 { get => name; set => name = value; }
        public string Exp { get => exp; set => exp = value; }
        public int Year { get => year; set => year = value; }
        public override string ToString()

        {
            return $"Группа - Учитель\n" +

            $"Имя - {Name}\n" +
            $"Года - {Year}\n" +
            $"Стаж - {exp}\n";
        }
    }
}


