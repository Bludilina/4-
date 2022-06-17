using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
             person person = new person();
             teacher teacher = new teacher();
             student student = new student();
             headofdepartment headofdepartment = new headofdepartment();

            Console.WriteLine(person.ToString());
            Console.WriteLine(student.ToString());
            Console.WriteLine(teacher.ToString());
            Console.WriteLine(headofdepartment.ToString());
            

            Console.ReadKey();

        }
    }
}
