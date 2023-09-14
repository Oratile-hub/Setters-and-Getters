using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setters_and_Getters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Oratile", 28, "Male");
            Student student2 = new Student("Jim", 25, "K");

            Console.WriteLine(student1.name);
            Console.WriteLine(student1.gender);
            Console.WriteLine(student2.name);
            Console.WriteLine(student2.gender);
            Console.WriteLine(Student.Studentcount);
            
            //freeze console
            Console.ReadLine();
        }
    }
}
