using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string znak;
            Console.WriteLine("введи первое чилсо");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введи второе чилсо");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введи знак: '+', '-', '*', '/'");
            znak = Console.ReadLine();

            if (znak == "+")
            {
                Console.WriteLine($"результат: {a + b}");
            }

            else if (znak == "-")
            {
                Console.WriteLine($"результат: {a - b}");
            }

            else if (znak == "*")
            {
                Console.WriteLine($"результат: {a * b}");
            }

            else if (znak == "/")
            {
                if (b >= 1)
                {
                    Console.WriteLine($"результат: {a / b}");
                }

                else
                {
                    Console.WriteLine("на ноль днлить нельзя!");
                }

            }

        }
    }
}
