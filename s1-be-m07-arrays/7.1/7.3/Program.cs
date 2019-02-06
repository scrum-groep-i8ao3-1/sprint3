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
            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = random.Next(0, 10001);
                array[i] = randomNumber;
                if (IsOdd(i))
                {
                    Console.WriteLine(array[i]);
                }
            }
                Console.ReadLine();
        }
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}  