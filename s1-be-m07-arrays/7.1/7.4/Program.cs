using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    class Program
    {
        static List<Char> chars = new List<char>();

        static void Main(string[] args)
        {
            addChars(ref chars);
            while(true)
            {
                Console.WriteLine("geef de lengte van het password minimaal 10 en maximaal 60");
                int lenght = Convert.ToInt32(Console.ReadLine());

                if (lenght < 60 && lenght > 10)
                {
                    Console.WriteLine(randompassword(lenght));
                }

                if (lenght > 60)
                {
                    Console.WriteLine(randompassword(60));
                    Console.WriteLine("je password is nu 60 tekens lang doe het de volgende keer wat korter");
                }

                if (lenght < 10)
                {
                    Console.WriteLine(randompassword(10));
                    Console.WriteLine("je password is nu 10 tekens lang doe het de volgende keer wat langer");
                }
            }
        }
        static string randompassword(int lenght)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            int j = 0;

            while (j < lenght)
            {
                sb.Append(chars[rnd.Next(0, chars.Count)]);
                j++;
            }

            return sb.ToString();
        }
        static void addChars(ref List<char> chars)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                chars.Add(i);
            }
            
            for (char i = 'A'; i <= 'Z'; i++)
            {
                chars.Add(i);
            }

            for (char i = '!'; i <= '?'; i++)
            {
                chars.Add(i);
            }

            for (char i = '0'; i <= '9'; i++)
            {
                chars.Add(i);
            }
        }
        
    }
}


