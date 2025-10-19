using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Person
    {
        public virtual void IntroduceYourself()
        {
            Console.WriteLine("здарова");
        }
    }

    class Teacher : Person
    {
        public override void IntroduceYourself()
        {
            Console.WriteLine("ну здарова");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.IntroduceYourself();

            Teacher t = new Teacher();
            t.IntroduceYourself();

            Console.ReadKey();
        }
    }
}
