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
            string geboortedatum = Convert.ToString(Console.ReadLine());
            DateTime datum = DateTime.Parse(geboortedatum);
            BerekenLeeftijd(geboortedatum);
        }
        public static void BerekenLeeftijd(string geboortedatum)
        {
        }
    }
}
