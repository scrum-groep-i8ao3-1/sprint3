using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Invoer getal1
            Console.Write("Voer getal1 in: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            
            //invoer getal2
            Console.Write("Voer getal2 in: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            //Roep getallen uit parameter Swap terug
            Swap(ref getal1, ref getal2);

            Console.Write("Getal 1 = " + getal1 + " Getal2 = " + getal2);
            Console.ReadLine();
        }

        /// <summary>
        /// Deze methode verwisseld de twee argumenten
        /// </summary>
        /// <param name="getal1">Een referentie naar het eerste getal</param>
        /// <param name="getal2">Een referentie naar het tweede getal</param>
        private static void Swap(ref int getal1, ref int getal2)
        {
            //Een geheugen plek voor getal2
            int savenumber = getal1;
            //Swap Getallen 1 en 2
            getal1 = getal2;
            getal2 = savenumber;
        }
    }
}