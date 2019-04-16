using System;
using System.Linq;

namespace LottoV2Program
{
    class LottoV2
    {
        static void Main(string[] args)
        {
            //zorgt voor random getal tussen de 1 en 6
            int Getal = 0;
            Random rand1 = new Random();
            Getal = rand1.Next(1, 6);
            Console.ReadLine();


            if (Getal == 1)
            //zorgt dat de kleur veranderd
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("dit is een andere kleur");
            }
            else if (Getal == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("dit is een andere kleur");
            }
            else if (Getal == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("dit is een andere kleur");
            }
            else if (Getal == 4)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("dit is een andere kleur");
            }
            else if (Getal == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("dit is een andere kleur");
            }
            else if (Getal == 6)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("dit is een andere kleur");
            }
            Console.ReadLine();

            int[] lottoNummers = new int[6];
            Random rand = new Random();
            int temp = 0;
            int count = 0;
            //zorgt dat de nummers tussen 1 en 46 blijven
            for (int i = 0; i < lottoNummers.Length; i++)
            {
                temp = rand.Next(1, 46);

                while (lottoNummers.Contains(temp) == false)
                {
                    lottoNummers[count] = temp;
                    count++;
                }

            }

            foreach (int i in lottoNummers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
