using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public int Grade;

        public void PrintInfo()
        {

            Console.WriteLine($"Студент: {FirstName} {LastName}, Возраст: {Age}, Оценка: {Grade}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.FirstName = "сережа";
            s1.LastName = "леонтьев";
            s1.Age = 19;
            s1.Grade = 5;

            student s2 = new student();
            s2.FirstName = "катя";
            s2.LastName = "морозова";
            s2.Age = 23;
            s2.Grade = 52;

            s1.PrintInfo();
            s2.PrintInfo();

            Console.ReadLine();

        }
    }
}
