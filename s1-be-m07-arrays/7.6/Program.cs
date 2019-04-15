using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6
{
    class Program
    {
        static void Main(string[] args)
        {

         //Gemaakt door kevin
         //Bepaald de grote van de array
         int[] numbers = new int[21];
         //Roept de random funtie op.
         Random rnd = new Random();
         

            // voegt nummers toe tot bepaalde max van de array is bereikt
            for (int i = 0; i < 20; i++)
            {
                int randomnummer = rnd.Next(10, 100);
                numbers[i] = randomnummer;
                Console.WriteLine(numbers[i]);
               
                


            }
            //Keert de values om die in de loop zijn gegenereerd
            Array.Reverse(numbers);
            //Laat de numers nogmaals zien maar dan omgekeerd dankzij de array.reverse
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
            




            Console.ReadKey();
        }
    }
}
