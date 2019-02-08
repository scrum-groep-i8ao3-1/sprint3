using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef getal 1");
            int intTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 2");
            int intTemp2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 3");
            int intTemp3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 4");
            int intTemp4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 5");
            int intTemp5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 6");
            int intTemp6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 7");
            int intTemp7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 8");
            int intTemp8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 9");
            int intTemp9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 10");
            int intTemp10 = Convert.ToInt32(Console.ReadLine());

            int[] berekening = new int[11];
            berekening[0] = intTemp;
            berekening[1] = intTemp2;
            berekening[2] = intTemp3;
            berekening[3] = intTemp4;
            berekening[4] = intTemp5;
            berekening[5] = intTemp6;
            berekening[6] = intTemp7;
            berekening[7] = intTemp8;
            berekening[8] = intTemp9;
            berekening[9] = intTemp10;
            int totaal = 0;
            for (int i = 0; i < berekening.Length; i++)
            {
                totaal += berekening[i];

            }
            Console.WriteLine(Convert.ToString(totaal));
            Console.ReadKey();
        }
    }
}
