using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;

        private double grade;
        public double Grade
        {
            get { return grade; }
            set
            {
                if (value >= 1 && value <= 10)
                    grade = value;
                else
                    Console.WriteLine("Ошибка: оценка должна быть от 1 до 10!");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {FirstName} {LastName}, Возраст: {Age}, Оценка: {Grade}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "катя ";
            s1.LastName = "морозова";
            s1.Age = 20;
            s1.Grade = 4.5;

            Student s2 = new Student();
            s2.FirstName = "морозова";
            s2.LastName = "катя";
            s2.Age = 19;
            s2.Grade = 5.0;

            s1.PrintInfo();
            s2.PrintInfo();

            Console.ReadLine();
        }
    }
}
