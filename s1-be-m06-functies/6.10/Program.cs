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
            Console.Write("Voer een willekeurig getal in Getal1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Voer nog een willekeurig getal in Getal2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

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
            int memo = getal1;
            getal1 = getal2;
            getal2 = memo;
        }
    }
}