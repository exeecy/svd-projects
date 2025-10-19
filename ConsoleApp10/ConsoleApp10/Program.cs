using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
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
                new Student("МАГА", 52     )
            };

            Student best = students[0];
            foreach (var s in students)
            {
                if (s.Grade > best.Grade)
                {
                    best = s;
                }
            }

            Console.WriteLine("Лучший студент: " + best.Name + " с оценкой " + best.Grade);
            Console.ReadKey();
        }
    }
}
