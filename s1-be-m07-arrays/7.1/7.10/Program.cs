using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._10
{
    class Program
    {
        static void Main(string[] args)
        {

            //Maakt de rijen en kollomen aan
            string[] Rijen = new string [5];
            decimal[,] Kollomen = new decimal[4, 4];
            
            
            
            //Slaat de naam op die door de gebruiker word ingevoerd 
            Console.WriteLine("Uw naam is?: ");
            string naam = Console.ReadLine();
            //Slaat de cijfers op die door de gebruiker worden ingevoerd
            Console.WriteLine("Wat is je Cijer voor Nederlands?: ");
            Kollomen[0, 0] = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Wat is je Cijer voor Engels?: ");
            Kollomen[1, 1] = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Wat is je Cijer voor Rekenen?: ");
            Kollomen[2, 2] = Convert.ToDecimal(Console.ReadLine());
            

            Console.Clear();

           
            //Berekening van Cijfer
            decimal berekening = Kollomen[0, 0] + Kollomen[1, 1]; 
            decimal berekening2 = Kollomen[2, 2] * 2;
            decimal berekening3 = berekening + berekening2;
            decimal berekening4 = berekening3 / 4;

            foreach (decimal element in Kollomen <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }
            
            
            //Geeft aan wat er bij elke rij moet staan
            Rijen[0] = "naam";
            Rijen[1] = "Nederlands   (weging 1)" + " " +  Kollomen[0, 0];
            Rijen[2] = "Engels       (weging 1)" + " " +  Kollomen[1, 1];
            Rijen[3] = "Rekenen      (weging 2)" + " " +  Kollomen[2, 2];
            Rijen[4] = "Gemiddelde" + " " +  berekening4;
            //Schrijft het in de console
            Console.Write(naam + System.Environment.NewLine);
            Console.Write(Rijen[1] + System.Environment.NewLine);
            Console.Write(Rijen[2] + System.Environment.NewLine);
            Console.Write(Rijen[3] + System.Environment.NewLine);
            Console.Write(Rijen[4]);


            Console.ReadKey();

        }  
    }
}
