using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    //Timur 
    //Getest door Daniel
    
    //inhoud van opdracht: dit is een random password genarator waarbij de user zelf de hoeveelheid karakters 
    //mag invullen dit moet wel Min 10 en Max 60 en als het niet tussen 10 en 60 zit moet het opnieuw worden gebeurd 

    class RandomNumberSample
    {
        static void Main(string[] args)
        {
            //aantal tekens vaststellen 
            Console.WriteLine("Hoe lang wil je je wachtwoord (min 10, max 60): ");
            int hoeveel = Convert.ToInt32(Console.ReadLine());

            //een array met alle tekens voor het random wachtwoord
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&?";
            Random t = new Random();
            string password = "";

            //if statement zodat de hoeveelheid gegeven karakters niet te laag of te hoog is
            if (hoeveel < 10 || hoeveel > 60)
            {
                Console.WriteLine("probeer het nog een keer");
                Console.ReadLine();
            }

            else
            {
                //het opstellen van het random password door telkens een van de 69 randoms karakter te pakken van de Array
                for (int i = 0; i < hoeveel; i++)
                {

                    password += chars[t.Next(0, 68)].ToString();
                }
                Console.WriteLine(password);
                Console.ReadLine();
            }
        }

    }

}
