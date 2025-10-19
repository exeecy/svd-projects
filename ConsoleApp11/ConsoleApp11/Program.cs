using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp11
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\Серёжа\Desktop\svd\ConsoleApp11\numbers.txt"; // путь к файлу

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл numbers.txt не найден!");
                return;
            }

            int sum = 0;
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (int.TryParse(line, out int number))
                {
                    sum += number;
                }
            }

            Console.WriteLine($"Сумма чисел в файле = {sum}");
        }
    }
}
