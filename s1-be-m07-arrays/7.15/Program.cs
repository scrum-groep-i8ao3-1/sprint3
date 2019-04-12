using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._15
{
    class Program
    {
        public string tekens = "";
        static void Main(string[] args)
        {
            //array 11 random tekens
            // geen 1 / 0 / i / o
            Random rnd = new Random();
            char Randomteken = ' ';
            //char Randomteken = (char)rnd.Next('A', 'Z');
            for (int teller = 0; teller < 11; teller++)
            {
                int randomnummer = rnd.Next(1, 4);
                switch (randomnummer)
                {
                    case 1:
                        Randomteken = (char)rnd.Next('A', 'Z');
                        break;
                    case 2:
                        Randomteken = (char)rnd.Next('a', 'z');
                        break;
                    case 3:
                        Randomteken = Convert.ToChar(Convert.ToString(rnd.Next(1, 9)));
                        break;


                }
                checked(Randomteken);
                if(checkers == 1)
            {
                    teller + -1;
            }
            }
            Console.WriteLine(tekens);
            Console.ReadLine();
        }
        public static void checker(char nummer)
        {
            Random == nummer;
            int checkers = 0;
            if (Randomteken == '0' || Randomteken == '1' || Randomteken == 'I' || Randomteken == 'i' || Randomteken == 'o' || Randomteken == 'O')
                {
                    //fout
                   i =1;
                }
                else
                {
                    //goed
                    tekens += Randomteken;
                }
            return checkers;
        }
    }
}
