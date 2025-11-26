using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = Math.Abs(number); 

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
            Console.ReadKey();
        }
    }
}