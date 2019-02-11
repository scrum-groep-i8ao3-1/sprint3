using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._12
{
    class project
    {
        //Timur 
        //getest door: Daniel
        //in deze code moet de user een wachtwoord en een key invullen daarna gaat het met de key alle letters in het ww verranderen naar de aangegeven
        //letters uit de array vervolgens laat hij het wachtwoord zien het wachtwoord met de key en dan weer het wachtwoord
        public static void Main()
        {
            //de gebruiker voert hier een wachtwoord in en een key 
            //er worden variabelen aan gemaakt 
            Console.WriteLine("vul een wachtwoord in (in Hoofdletters)");
            string encrypted_text = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Vul een key in tussen de 1 en de 26");
            int key = Convert.ToInt32(Console.ReadLine());
            int verplaats = 0;
            char character = '0';
            encrypted_text = encrypted_text.ToUpper();

            //dit is de array met alle karakters het staat er twee keer in zodat het weer kan terug loopen naar de A
            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                           'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            {
                //while is zodat key niet verder gaat dan 26 en het wordt dan opnieuw gevraagt 
                while (key > 26 || key < 1)
                {
                    Console.WriteLine("Voer een geldige key in ");
                    Console.WriteLine("Vul een key in tussen de 1 en de 26");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                    {
                        //hier word het wachtwoord met key aan elkaar gezet en wordt alle karakters van de array
                        string ww_text = "";
                        foreach (char a in encrypted_text)
                        {
                            character = a;

                            if (character == '\'' || character == ' ')
                                continue;

                            //hier wordt verplaats elke keer de letter van het wachtwoord en verplaatst het met het getal van de key 
                            //ww_text is het wachtwoord na dat het is verranderd met de key
                            verplaats = Array.IndexOf(alphabet, character) + key;
                            ww_text += alphabet[verplaats];
                    }

                    //het resultaat wordt gedisplayed
                    Console.WriteLine("Dit is het wachtwoord: " + encrypted_text);
                    Console.WriteLine("Het versleutelde wachtwoord is: " + ww_text);
                    Console.WriteLine("Het originele wachtwoord was: " + encrypted_text);
                    Console.ReadKey();
                    }               
            }
            
        }
    }
}
