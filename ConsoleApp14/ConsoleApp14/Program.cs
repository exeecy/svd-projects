using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(0, 101);

            Console.WriteLine("Массив: " + string.Join(", ", numbers));
            Console.Write("Введите число для поиска: ");
            int searchNumber = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == searchNumber)
                {
                    found = true;
                    break;
                }

            if (found)
                Console.WriteLine("Найдено");
            else
                Console.WriteLine("Не найдено");
        }
    }
}
