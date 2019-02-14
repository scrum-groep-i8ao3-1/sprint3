using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //array 11 random tekens
            // geen 1 / 0 / i / o
            string tekens = "";
            Random rnd = new Random();
            char Randomteken = ' ';
            //char Randomteken = (char)rnd.Next('A', 'Z');
            for (int i = 0; i < 11; i++)
            {
                int randomnummer = rnd.Next(3, 3);
                switch (randomnummer)
                {
                    case 1:
                        Randomteken = (char)rnd.Next('A', 'Z');
                        break;
                    case 2:
                        Randomteken = (char)rnd.Next('a', 'z');
                        break;
                    case 3:
                        Randomteken = Convert.ToChar(rnd.Next(1, 9));
                        break;


                }
                if (Randomteken == '0' || Randomteken == '1' || Randomteken == 'I' || Randomteken == 'i' || Randomteken == 'o' || Randomteken == 'O')
                {
                    //fout
                    i--;
                }
                else
                {
                    //goed
                    tekens += Randomteken;
                }
          
            }
            Console.WriteLine(tekens);
            Console.ReadLine();
        }
    }
}
