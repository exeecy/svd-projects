using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
                numbers[i] = rnd.Next(0, 101);

            Console.WriteLine("Исходный массив: " + string.Join(", ", numbers));

            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 14; j++)
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }

            Console.WriteLine("Отсортированный массив: " + string.Join(", ", numbers));
        }
    }
}
