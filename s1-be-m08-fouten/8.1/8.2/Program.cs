using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een datum in: (dd/mm/YYYY) ");
            try
            {

                string invoer = Console.ReadLine();
                DateTime datum = DateTime.Parse(invoer);
                int maand = datum.Month;
                int jaar = datum.Year;
                int dagen = datum.Day;
                int days = DateTime.DaysInMonth(jaar, maand);
                Console.WriteLine(days);
                Console.ReadLine();

            }
            catch
            {

                Console.WriteLine("Dit is een ongeldige datum");
                Console.ReadKey();

            }
        }
    }
}