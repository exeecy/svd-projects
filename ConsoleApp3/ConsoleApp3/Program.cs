using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 32, 54, 56, 72, 57, 24, 90 };

            int min = mas[0];
            int max = mas[0];

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);

                if (mas[i] < min)
                {
                    min = mas[i];
                }

                if (mas[i] > max)
                {
                    max = mas[i];
                }

                Console.WriteLine("минимум = " + min);
                Console.WriteLine("максимум = " + max);




            }

        }
    }
}
