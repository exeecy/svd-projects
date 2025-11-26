using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPerfect(number))
                Console.WriteLine($"{number} является совершенным числом");
            else
                Console.WriteLine($"{number} не является совершенным числом");

            Console.ReadKey();
        }

        static bool IsPerfect(int number)
        {
            if (number <= 1)
                return false;

            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum == number;
        }
    }
}