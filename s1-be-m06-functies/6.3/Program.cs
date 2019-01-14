using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    //danny
    //20
    //niet gebeurd
    //14-12-2018
    //naakijk test 1 
    //getest door tom
    // goed gekeurt - 4 12 2002 [boogschutter]
    //kijk acceptatie test voor overige testen!
    class Program
    {
        enum Day { ram = 01, stier = 2, tweelingen = 3, kreeft = 4, leeuw = 5, maagd = 6, weegschaal = 7, schoprioen = 8, boogschutter = 9, steenbok = 10, waterman = 11, vissen = 12 };

        static void Main(string[] args)
        {
            Console.WriteLine("geef een datum in als : d/mm/yyyy");
            String input = Console.ReadLine();
            DateTime inputdate = DateTime.Parse(input);
            String maandString = inputdate.ToString("MM");
            String dagString = inputdate.ToString("dd");
            int dag = int.Parse(dagString);
            int maand = int.Parse(maandString);
            zodiac(maand, dag);
            // The example displays the following output:
            //       6/12/2008 12:00:00 AM
        }
        public static void zodiac(int maand, int dag)
        {
            if (maand == 03 && dag >= 21 || maand == 04 && dag < 21) //ram
            {
                Console.WriteLine(Day.ram);
                Console.ReadLine();
            }
            else if (maand == 04 && dag >= 21 || maand == 05 && dag< 22) //stier
            {
                Console.WriteLine(Day.stier);
                Console.ReadLine();

            }
            else if (maand == 05 && dag >= 22 || maand == 06 &&dag < 22) //tweeling
            {
                Console.WriteLine(Day.tweelingen);
                Console.ReadLine();
            }
            else if (maand == 06 && dag >= 22 || maand == 07 &&dag < 23)//kreeft
            {
                Console.WriteLine(Day.kreeft);
                Console.ReadLine();
            }
            else if (maand == 07 && dag >= 24 || maand == 08 &&dag < 24)//leeuw
            {
                Console.WriteLine(Day.leeuw);
                Console.ReadLine();
            }
            else if (maand == 08 && dag >= 24 || maand == 09 &&dag < 24)//maagd
            {
                Console.WriteLine(Day.maagd);
                Console.ReadLine();
            }
            else if (maand == 09 && dag >= 24 || maand == 010 && dag< 23)//weegschaal
            {
                Console.WriteLine(Day.weegschaal);
                Console.ReadLine();
            }
            else if (maand == 10 && dag >= 24 || maand == 11 && dag< 23)//schorpioen
            {
                Console.WriteLine(Day.schoprioen);
                Console.ReadLine();
            }
            else if (maand == 11 && dag >= 23|| maand == 12 && dag< 23)//boogschutter
            {
                Console.WriteLine(Day.boogschutter);
                Console.ReadLine();
            }
            else if (maand == 12 && dag >= 23 || maand == 01 && dag < 21)//steenbok
            {
                Console.WriteLine(Day.steenbok);
                Console.ReadLine();
            }
            else if (maand == 01 && dag >= 21 || maand == 02 &&dag < 19)//waterman
            {
                Console.WriteLine(Day.waterman);
                Console.ReadLine();
            }
            else if (maand == 02 && dag >= 19 || maand == 03 && dag< 21)//vissen
            {
                Console.WriteLine(Day.vissen);
                Console.ReadLine();
            }

        }
    }
}
