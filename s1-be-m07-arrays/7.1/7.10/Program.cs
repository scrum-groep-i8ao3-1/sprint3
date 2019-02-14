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
            double [,] Kollomen = new double[4, 4];
            
            
            
            //Slaat de naam op die door de gebruiker word ingevoerd 
            Console.WriteLine("Uw naam is?: ");
            string naam = Console.ReadLine();
            //Slaat de cijfers op die door de gebruiker worden ingevoerd
            Console.WriteLine("Wat is je Cijer voor Nederlands?: ");
            Kollomen[0, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je Cijer voor Engels?: ");
            Kollomen[1, 1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is je Cijer voor Rekenen?: ");
            Kollomen[2, 2] = Convert.ToDouble(Console.ReadLine());
            

            Console.Clear();

            
           
            //Berekening van Cijfer
            double berekening = Kollomen[0, 0] + Kollomen[1, 1]; 
            double berekening2 = Kollomen[2, 2] * 2;
            double berekening3 = berekening + berekening2;
            double berekening4 = berekening3 / 4;
            
            
            
            //Geeft aan wat er bij elke rij moet staan
            Rijen[0] = "naam";
            Rijen[1] = "Nederlands   (weging 1)" + " " +  Kollomen[0, 0]; //nederlands
            Rijen[2] = "Engels       (weging 1)" + " " +  Kollomen[1, 1]; //engels
            Rijen[3] = "Rekenen      (weging 2)" + " " +  Kollomen[2, 2]; //rekenen
            Rijen[4] = "Gemiddelde" + " " +  berekening4; //gemiddelde




            //gemaakt door Danny

            //Schrijft het in de console
            Console.Write(naam + System.Environment.NewLine); //naam
            for (int i = 0; i < 3;i ++ )
            {
                if (Kollomen[i,i] < Convert.ToDouble(5.5))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(Rijen[i + 1] + System.Environment.NewLine);
            }
  
            
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Rijen[4]);


            Console.ReadKey();

        }  
    }
}
