using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            int gcd = FindGCD(a, b);
            Console.WriteLine($"наибольший общий делитель чисел {a} и {b} равен {gcd}");
            Console.ReadKey();
        }

        static int FindGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}