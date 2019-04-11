using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    //jairo
    class Program
    {
        public static void Main()
        {
            IsSchrikkelJaar();
            IsSchrikkelJaar(10);
            Console.ReadLine();
        }


        static void IsSchrikkelJaar()
        {
            //geeft aan of het huidige jaar een schrikkeljaar is
            int jaar = Convert.ToInt32(DateTime.Now.Year);
            bool waarheid = DateTime.IsLeapYear(jaar);
            if (waarheid == true)
            {
                Console.WriteLine("dit is een schrikkeljaar");
            }
            else
            {
                Console.WriteLine("dit is geen schrikkeljaar");
            }
            Console.ReadLine();
        }
        static void IsSchrikkelJaar(int year)
        {
            bool b = true;

            //geeft aan of een opgegeven jaar in een schrikkeljaar is
            Console.WriteLine("geef het jaar");
            year = Convert.ToInt32(Console.ReadLine());

            b = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if (b)
            {
                Console.WriteLine(year + " het is een schrikkeljaar ");
            }
            else
            {
                Console.WriteLine(year + " het is geen schrikkeljaar ");
            }
            //geeft aan of het in de huidige eeuw is
            if (year < 50)
            {
                Console.WriteLine("het jaartal ligt in de huidige eeuw");
            }
            else if (year >= 50)
            {
                Console.WriteLine("Het jaartal ligt niet in de huidige eeuw");
            }

            Console.ReadLine();
        }
    }
}