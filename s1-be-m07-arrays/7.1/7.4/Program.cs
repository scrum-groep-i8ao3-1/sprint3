using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{ 
    //Timur 
    //getest door Daniel en Jairo
    //Deze code is een random password genarator die maximaal 60 en minimaal 10 karakters mogen bevatten 
    //de lengte die tussen de 10 en 60 zit moet de user zelf invoeren 
    class Program
    {
        static void Main(string[] args)
        {
            //heir wordt de user input geconvert naar een int
            Console.WriteLine("hoe lang wilt u uw wachtwoord (Max 60, Min 10 tekens)");
            int aantal = Convert.ToInt32(Console.ReadLine());

            //hier wordt de array met tekens opgesteld en er wordt een random aan gemaakt
            char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#@$%&*?".ToCharArray();
            Random r = new Random();
            string randomstr = " ";

            //voor als de user geen geldige input in heeft gevuld
            if (aantal < 10 || aantal > 60)
            {
                Console.WriteLine("Dit is geen geldige keuze probeer het opnieuw");
                Console.ReadLine();
            }

            //voor als de user een geldige input in heeft gevuld 
            //gaat het hier random tekens uit array halen tot i gelijk is aan de input van de user 
            else
            {
                for (int i = 0; i < aantal; i++)
                {
                    randomstr += array[r.Next(0, 70)].ToString();
                }
            }
            Console.WriteLine(randomstr);
            Console.ReadLine();


        }
        
    }
}


