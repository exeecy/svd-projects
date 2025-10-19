using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            string filePath = "users.txt"; // имя файла

            // Добавляем запись в конец файла
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{name}: {age}");
            }

            Console.WriteLine("Данные успешно записаны в файл users.txt!");
        }
    }
}
