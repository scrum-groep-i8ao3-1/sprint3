using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een Getal in die u wilt delen. ");
            Console.WriteLine("Getal 1. ");
            double deeltal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer het getal deler in. ");
            double deler = Convert.ToInt32(Console.ReadLine());
            double quotient = deeltal / deler;
            if (deeltal == 0 || deler == 0)
            {
                Console.WriteLine("Wie deelt door nul is een snul!");
            }
            else
            {
                Console.WriteLine("Uitkomst: "+ quotient);
            }
            Console.ReadKey();
        }
    }
}
