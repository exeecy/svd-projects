using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            string znak;

            try
            {
                Console.WriteLine("введи первое число:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("введи второе число:");
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
                    Console.WriteLine($"результат: {a / b}"); // тут тоже поймаем ошибку
                }
                else
                {
                    Console.WriteLine("Ошибка: неизвестный знак операции!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: нужно вводить только числа!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: делить на ноль нельзя!");
            }
        }
    }
}
