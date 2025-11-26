using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число:");
            int n = int.Parse(Console.ReadLine());

            long result = Factorial(n);
            Console.WriteLine($"факториал {n}! = {result}");

            Console.ReadKey();
        }

        static long Factorial(int n)
        {
            if (n <= 1)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}