using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schrikkeljaar
            int year = DateTime.Now.Year;
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Dit jaar is een schrikkeljaar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dit jaar is geen schrikkeljaar.");
            }
            //huidige dag doordeweeks of weekend
            var day = DateTime.Now.DayOfWeek;
            if (day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Thursday || day == DayOfWeek.Wednesday || day == DayOfWeek.Friday)
            {
                Console.WriteLine("Het is vandaag een doordeweekse dag.");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Het is vandaag weekend");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            //einde read */all
            Console.ReadKey();
            //einde read */all
        }
    }
}
