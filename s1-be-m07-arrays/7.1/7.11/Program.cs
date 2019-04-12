using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11
{
    class Program
    {
        //tom
        //af op 30-1-2019
        //nagekeken door danny
        static void Main(string[] args)
        {
            //Variablen
            Random random = new Random();
            int randomnumber;

            int[] numbers1 = new int[10];
            int[] numbers2 = new int[10];

            //Random getal in loop
            for (int i = 0; i < 10; i++)
            {
                randomnumber = random.Next(10, 99);
                numbers1[i] = randomnumber;
                randomnumber = random.Next(10, 99);
                numbers2[i] = randomnumber;
            }
            for (int i = 0;i < 20 ;i++)
            {
                //Het laten zien van de 10 nummers in de array
                if(i < 10)
                {
                    if(i == 0)
                    {
                        Console.Write("array 1: ");
                    }
                    Console.Write(numbers1[i] + " ");
                }
                else
                {
                    if (i == 10)
                    {
                        Console.WriteLine(" ");
                        Console.Write("array 2: ");
                    }
                    Console.Write(numbers2[(i - 10)] + " ");
                }
            }
            int totaal = 0;

            //De som uitwerken
            for (int i = 0; i < 10; i++)
            {
                totaal = numbers1[i] + numbers2[i];
                if (i == 0)
                {
                    Console.WriteLine(" ");
                    Console.Write("de som is: ");
                }
                Console.Write(Convert.ToString(totaal));
                Console.Write(" ");
            }
            Console.ReadKey();

        }
    }
}
