using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    struct Meeting
    {
        public DayOfWeek Day;
        public string Time;
        public string Subject;

        public Meeting(DayOfWeek day, string time, string subject)
        {
            Day = day;
            Time = time;
            Subject = subject;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Meeting[] meetings =
            {
                new Meeting(DayOfWeek.Monday, "8:30", "придти в колледж"),
                new Meeting(DayOfWeek.Wednesday, "16:00", "пойти в гости к лукашевичу"),
                new Meeting(DayOfWeek.Friday, "12:00", "уйти из колледжа"),
                new Meeting(DayOfWeek.Wednesday, "18:00", "поотом к катюхе")
            };

            Console.WriteLine("важнейшее дело в среду:\n");

            foreach (var meeting in meetings)
            {
                if (meeting.Day == DayOfWeek.Wednesday)
                {
                    Console.WriteLine($"{meeting.Time} — {meeting.Subject}");
                }
            }

            Console.ReadKey();
        }
    }
}