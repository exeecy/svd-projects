using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Timer
    {
        public delegate void TickHandler();

        public event TickHandler OnTick;

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000); 
                OnTick?.Invoke();  
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();

            timer.OnTick += ShowTime;

            timer.Start();
        }

        static void ShowTime()
        {
            Console.WriteLine("Текущее время: " + DateTime.Now.ToLongTimeString());
        }
    }
}
