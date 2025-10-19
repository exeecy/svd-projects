using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 2; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine($"сумма четных чисел от 0 до {n} равна {sum}");
        }
    }
}
