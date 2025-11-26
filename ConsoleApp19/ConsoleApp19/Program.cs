using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("МОРОЗОВА", 100),
                new Student("ИЛЬЯЗ", 0),
                new Student("ЛУКАШЕВИЧ", 1),
                new Student("ЛЕОН", -100),
                new Student("МАГА", 52)
            };

            var sorted = students.OrderByDescending(s => s.Grade);

            var filtered = students.Where(s => s.Grade > 7);

            Console.WriteLine("сортировка по убыванию:");
            foreach (var s in sorted)
            {
                Console.WriteLine($"{s.Name} — {s.Grade}");
            }

            Console.WriteLine("\nстуденты с оценкой > 7:");
            foreach (var s in filtered)
            {
                Console.WriteLine($"{s.Name} — {s.Grade}");
            }

            Console.ReadKey();
        }
    }
}