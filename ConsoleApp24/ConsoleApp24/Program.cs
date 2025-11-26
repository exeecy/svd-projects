using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите колво чисел фибоначчи: ");
            int n = int.Parse(Console.ReadLine());

            long a = 0, b = 1;

            Console.WriteLine("первые " + n + " чисел фибоначчи:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                long temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}