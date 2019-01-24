using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
    //daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            IsWeekend();
        }
        public static void IsWeekend()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            var culture = new System.Globalization.CultureInfo("de-DE");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                Console.WriteLine("Today it is: " + today + " so it's weekend.");
            }
            else
                Console.WriteLine("Today it is: " + today + " so it's a workday.");
            Console.ReadKey();
        }
    }
}