using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //applicatie vraagt om een getal
            Console.WriteLine("Geef een aantal om lege regels te schrijven");
            int input = Convert.ToInt32(Console.ReadLine());

            //applicatie maakt een variable teller aan die het aantal regels telt
            int teller = 0;
            //de input gaat een loop in, en het aantal gewenste regels word geschreven
            for (int i = 0; i < input; i++)
            {
                //teller wordt telkens met 1 verhoogd wanneer die door de loop wordt geactiveerd
                teller += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(teller + "           ");
            }
            Console.ReadKey();
        }
    }
}
