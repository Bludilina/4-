using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class student: person
    {

        public student(string name, int year, int marks);


        public student() { }

        private string name;
        private int year;
        private int marks;

        public string Name1 { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public int Marks { get => marks; set => marks = value; }

        public override string ToString()
        {
            return $"Группа - Студент\n" +

            $"Имя - {Name}\n" +
            $"Года - {Year}\n" +
            $"Оценки - {marks}\n";
        }
    }

}
