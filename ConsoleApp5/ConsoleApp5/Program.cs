using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine().ToLower(); // приводим к нижнему регистру

            int count = 0;
            string vowels = "aeiouy"; // список гласных

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество гласных букв: {count}");
        }
    }
}
