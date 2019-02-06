using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer uw geboortedatum in. ");
            DateTime geboortedatum = Convert.ToDateTime(Console.ReadLine());
            BerekenLeeftijd(geboortedatum);
        }
        public static void BerekenLeeftijd(DateTime geboortedatum)
        {
            int dag = geboortedatum.Day;
            int maand = geboortedatum.Month;
            DateTime today = DateTime.Today;
            int age = today.Year - geboortedatum.Year; 
            if (geboortedatum > today.AddYears(-age))
            {
                if (dag == 29 && maand == 2)
                {
                    age = age / 4;
                }
                else
                {
                    --age;
                }
            }
            Console.WriteLine("Uw leeftijd: " + age);
            Console.ReadLine();
        }
    }
}
