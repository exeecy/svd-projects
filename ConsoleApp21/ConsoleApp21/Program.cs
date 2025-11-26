using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите строку: ");
            string input = Console.ReadLine();

            string cleaned = new string(input
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            bool isPalindrome = cleaned.SequenceEqual(cleaned.Reverse());

            if (isPalindrome)
                Console.WriteLine("строка палиндром");
            else
                Console.WriteLine("строка не палиндром");

            Console.ReadKey();
        }
    }
}