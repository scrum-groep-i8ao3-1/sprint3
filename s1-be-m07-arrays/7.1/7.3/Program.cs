using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[25];
            int[] array2 = new int[25];
            int[] array3 = new int[25];

            //vullen array
            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = random.Next(0, 10001);
                array[i] = randomNumber;
            }
            // uitlezen array
            //forloop
            // controleer  even
            Console.WriteLine("Even getallen");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            //forloop
            // controleer oneven.
            Console.WriteLine("Oneven getallen");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ReadLine();
        }
    }
}  