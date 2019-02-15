using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een Wachtwoord in: ");
            string ww = Convert.ToString(Console.ReadLine());
            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                           'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', '!', '"', '#', '&', '%', '(', ')', '*', '+', '-', ',', '.', '/', ':', ';', '<', '>', '=', '?', '@', '`', '{', '}', '[', ']', '|', '\''};
            Random random = new Random();
            string hexastring = "";
            string randomstring = "";
            for (int i = 0; i < ww.Length; i++)
            {
                string randomstr = alphabet[random.Next(0, 88)].ToString();
                randomstring += randomstr;
                foreach (byte b in randomstr)
                {
                    foreach (byte c in ww)
                    {
                        int a = b + c;
                        if (a > 127)
                        {
                            a = a - 128;
                        }
                        hexastring += a.ToString("X");
                    }
                }
            }
            Console.WriteLine("Uw Wachtwoord: " + ww);
            Console.WriteLine("Uw key: " + randomstring);
            Console.WriteLine("Uw Hexadecimale key: " + hexastring);
            Console.ReadKey();
        }
    }
}