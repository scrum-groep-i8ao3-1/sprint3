using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = random.Next(0, 101);
                array[i] = randomNumber;
            }
            int max = array.Max();
            int min = array.Min();
            double sum = array.Sum();
            double gem = sum / 10;
            string result = string.Join(";", array.Select(x => x.ToString()).ToArray());
            Console.Write(result);
            Console.WriteLine();
            Console.WriteLine("Hoogste getal: " + max);
            Console.WriteLine("Laagste getal: " + min);
            Console.WriteLine("Som van de array: " + sum);
            Console.WriteLine("Gemiddelde van de array: " + gem);
            Console.ReadLine();
        }
    }
}
