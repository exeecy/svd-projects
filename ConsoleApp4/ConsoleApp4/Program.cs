using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static int a;
        static void IsEven()
        {
            Console.WriteLine("ввелите число: ");
            a = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            IsEven();
            bool pro = a % 2 == 0;

            if (a % 2 == 0)
            {
                Console.WriteLine(pro);
            }

            if (a % 2 != 0)
            {
                Console.WriteLine(pro);
            }




        }
    }
}
