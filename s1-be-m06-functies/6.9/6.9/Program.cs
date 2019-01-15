using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._9
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //klok laten zien!
        static public Array nummer(int input)
        {
            //array var maken
            string[,] Onummer = new string[6,6];
            if (input == 0){
                for (int teller = 6; teller >= 0; teller--)
                {
                    Onummer[teller, 6] = "*";
                    Onummer[6, teller] = "*";
                }
                for (int teller = 6; teller >= 0; teller--)
                {
                    Onummer[teller, 6] = "*";
                    Onummer[6, teller] = "*";
                }
            }
            else if (input == 1)
            {
                for (int teller = 6; teller >= 0; teller--)
                {
                    Onummer[teller, 3] = "*";
                    Onummer[teller, 4] = "*";
                }
                for (int teller = 6; teller >= 3; teller--)
                {
                    Onummer[0, teller] = "*";
                    Onummer[1, teller] = "*";
                }
            }
            else if (input == 2)
            {

            }
            else if (input == 3)
            {

            }
            else if (input == 4)
            {

            }
            else if (input == 5)
            {

            }
            else if (input == 6)
            {

            }
            else if (input == 7)
            {

            }
            else if (input == 8)
            {

            }
            else if (input == 9)
            {

            }
            else
            {

            }
            return Onummer;
        }
    }
}
