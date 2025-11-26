using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string znak;

            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак: '+', '-', '*', '/'");
            znak = Console.ReadLine();

            switch (znak)
            {
                case "+":
                    Console.WriteLine($"Результат: {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {a * b}");
                    break;
                case "/":
                    if (b != 0)
                        Console.WriteLine($"Результат: {a / b}");
                    else
                        Console.WriteLine("На ноль делить нельзя!");
                    break;
                default:
                    Console.WriteLine("Неверный знак операции!");
                    break;
            }

            Console.ReadKey();
        }
    }
}