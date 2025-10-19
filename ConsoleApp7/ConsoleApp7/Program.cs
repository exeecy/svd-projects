using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
    }

    class Teacher : Person
    {
        public string Subject;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "katya";
            teacher.LastName = "morozova";
            teacher.Age = 40;
            teacher.Subject = "иностранный язык";

            Console.WriteLine("Имя: " + teacher.FirstName);
            Console.WriteLine("Фамилия: " + teacher.LastName);
            Console.WriteLine("Возраст: " + teacher.Age);
            Console.WriteLine("Предмет: " + teacher.Subject);

            Console.ReadLine();
        }
    }
}
