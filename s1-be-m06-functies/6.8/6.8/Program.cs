using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef cijfers op : ");
            String lijst = Console.ReadLine();
            berekening(lijst);
        }
        public static void berekening(string lijst)
        {
            int lenght = lijst.Length;
            int totaal = 0;
            for (int teller = 0; teller < lenght ;teller++ )
            {
                string transformator1 = lijst[teller].ToString();
                int transformator2 = System.Convert.ToInt32(transformator1);
                totaal += transformator2;

            }
            string output = totaal.ToString();
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
