using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            int reversed = 0;
            int temp = Math.Abs(number);

            while (temp > 0)
            {
                reversed = reversed * 10 + temp % 10;
                temp /= 10;
            }

            if (number < 0)
                reversed = -reversed;

            Console.WriteLine($"перевернутое число: {reversed}");
            Console.ReadKey();
        }
    }
}