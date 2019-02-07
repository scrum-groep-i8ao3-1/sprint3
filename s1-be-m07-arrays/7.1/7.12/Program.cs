using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._12
{
    class project
    {
        public static void Main()
        {
            Console.WriteLine("vul een wachtwoord in (in Hoofdletters)");
            string encrypted_text = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Vul een key in tussen de 1 en de 26");
            int key = Convert.ToInt32(Console.ReadLine());
            int verplaats = 0;
            char character = '0';
            encrypted_text = encrypted_text.ToUpper();

            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                           'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            {
                while (key > 26 || key < 1)
                {
                    Console.WriteLine("Voer een geldige key in ");
                    Console.WriteLine("Vul een key in tussen de 1 en de 26");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                    {
                        string decoded_text = "";
                        foreach (char a in encrypted_text)
                        {
                            character = a;

                            if (character == '\'' || character == ' ')
                                continue;

                            verplaats = Array.IndexOf(alphabet, character) + key;
                            decoded_text += alphabet[verplaats];                   
                        }
                    Console.WriteLine("Dit is het wachtwoord: " + encrypted_text);
                    Console.WriteLine("Het versleutelde wachtwoord is: " + decoded_text);
                    Console.WriteLine("Het originele wachtwoord was: " + encrypted_text);
                    Console.ReadKey();
                    }               
            }
            
        }
    }
}
