using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's birth date (as mm-dd-yyyy): ");
            string invoer = Console.ReadLine();
            checker(invoer);

        }
        public static void Message(string bericht)
        {
            Console.WriteLine(bericht);
            Console.ReadLine();
        }
        public static void berekening(int dag, int maand, int jaar)
        {
            if (dag > 31 || maand > 12 || maand < 1 || dag < 1)
            {
                Message("dit is een foute datum");
            }
            else
            {
                int days = DateTime.DaysInMonth(jaar, maand);
                string output = days.ToString();
                Message("er zitten "+ output +" dagen in deze maand");
            }
        }
        public static void checker(string invoer)
        {
            //00-00-0000
            //0123456789
            //01 34 6789
            int number1 = (Convert.ToInt32(invoer[0]) - 48) ; //maand 1
            int number2 = (Convert.ToInt32(invoer[1]) - 48); //maand 2
            int totaal1 = (number1 + number2);
            int number3 = (Convert.ToInt32(invoer[3]) - 48); //dag 1
            int number4 = (Convert.ToInt32(invoer[4]) - 48); //dag 2
            int totaal2 = (number3 + number4);
            if(number1 == 0 || number1 == 1) {
                if ( number2 > 0 || number2 <= 9 )
                {
                    if (number1 == 1 && number2 > 2 || number1 == 0 && number2 == 0)
                    {
                        Message("dit is geen goeie maand");
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        checkerdag(invoer);
                        return;
                    }
                }
                else {
                    Message("dit is geen goeie maand");
                    System.Environment.Exit(1);
                }
            }
            else
            {
                Message("dit is geen goeie maand!");
                System.Environment.Exit(1);
            }
            
        }
        public static void checkerdag(string invoer)
        {
            //00-00-0000
            //0123456789
            //01
            int[] array = new int[8];
            string maand = string.Empty;
            string jaar = string.Empty;
            string dagen = string.Empty;
            dagen += invoer[3];
            dagen += invoer[4];
            maand += invoer[0];
            maand += invoer[1];
            jaar += invoer[6];
            jaar += invoer[7];
            jaar += invoer[8];
            jaar += invoer[9];
            int dagen2 = Convert.ToInt32(dagen);
            int dtotaal = (Convert.ToInt32(invoer[1]) + Convert.ToInt32(invoer[0]));
            int jaar2 = Convert.ToInt32(jaar);
            int maand2 = Convert.ToInt32(maand);
            int days = DateTime.DaysInMonth(jaar2, maand2);
            if (dtotaal < 1 || days < dagen2)
                {
                    Message("de dag is verkeerd");
                    System.Environment.Exit(1);
                }
                else
                {
                DateTime dagtijd;
                DateTime.TryParse(invoer, out dagtijd);
                    int dagout = dagtijd.Day;
                    int maandout = dagtijd.Month;
                    int jaarout = dagtijd.Year;
                    berekening(dagout, maandout, jaarout);

                }
        }
    }
}