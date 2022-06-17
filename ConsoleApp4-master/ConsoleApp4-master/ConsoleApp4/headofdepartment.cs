using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class headofdepartment : person
    {
        public headofdepartment(string name, int year);

        private string name;
        private int year;

        public string Name1 { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public override string ToString()

        {
            return $"Группа - Заведующий кафедры\n" +

            $"Имя - {Name}\n" +
            $"Года - {Year}\n";


        }
    }
}
