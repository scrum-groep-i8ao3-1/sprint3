using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._9
{
    /*
     * Maak een 2D array met daarin de volgende informatie van de leden van jullie groep: 

Studentnummer 

Voornaam 

Achternaam 

Geboortedatum 

Geboorteplaats 

Alle informatie moet als volgt op het scherm worden weergegeven (voorbeeld): 

Jan Boswinkel (0234567) is geboren op 12 maart 1998 in Hengelo 

Gerrit de Vries (0123456) is geboren op 31 december 1999 in Borne 

etc.
     */
    class Program
    {
        //gemaakt door danny
        //nagekeken door tom
        // goed gekeurt
        static void Main(string[] args)
        {
            //variables maken
            String[,] lijst = new string[6, 5];
            //danny
            lijst[0, 0] = "0306783"; //studenten nummer
            lijst[0, 1] = "danny"; //naam
            lijst[0, 2] = "lanssink"; //achternaam
            lijst[0, 3] = "24-2-2002"; //geboorte datum
            lijst[0, 4] = "enschede"; //geboorteplaats
            //danny
            //tom
            lijst[1, 0] = "0311319";
            lijst[1, 1] = "tom";
            lijst[1, 2] = "morskieft";
            lijst[1, 3] = "04-12-2001";
            lijst[1, 4] = "hengelo";
            //tom
            //kevin
            lijst[2, 0] = "0309816";
            lijst[2, 1] = "kevin";
            lijst[2, 2] = "schreuder";
            lijst[2, 3] = "24-12-1994";
            lijst[2, 4] = "veldhoven";
            //kevin
            //daniel
            lijst[3, 0] = "0309816";
            lijst[3, 1] = "daniël";
            lijst[3, 2] = "van der wel";
            lijst[3, 3] = "07-04-2002";
            lijst[3, 4] = "enschede";
            //daniel
            //timur
            lijst[4, 0] = "0310275";
            lijst[4, 1] = "timur";
            lijst[4, 2] = "kocoz";
            lijst[4, 3] = "8-12-2002";
            lijst[4, 4] = "enschede";
            //timur
            //jairo
            lijst[5, 0] = "0313119";
            lijst[5, 1] = "tom";
            lijst[5, 2] = "morskieft";
            lijst[5, 3] = "04-12-2001";
            lijst[5, 4] = "hengelo";
            //jairo
            for (int teller = 0; teller < 5; teller++)
            {
                Console.WriteLine(lijst[teller, 1] + " " +lijst[teller, 2] + " " + lijst[teller, 0] + " is geboren op " + lijst[teller, 3]+ " in " +lijst[teller, 4] + ".");
            }
            Console.Read();
        }
    }
}
