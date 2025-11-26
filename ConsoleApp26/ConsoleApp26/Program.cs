using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 101);
            int guess = 0;

            Console.WriteLine("отгадай число от 1 до 100");

            while (guess != secretNumber)
            {
                Console.Write("пробуй: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < secretNumber)
                    Console.WriteLine("больше");
                else if (guess > secretNumber)
                    Console.WriteLine("меньше");
                else
                    Console.WriteLine("красава угадал");
            }

            Console.ReadKey();
        }
    }
}