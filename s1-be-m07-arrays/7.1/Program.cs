using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //revamp
            //danny
            //input
            Console.WriteLine("voer 5 gehele getallen in.");
            String input = Console.ReadLine();
            //variables maken
            string[] lijst = new string[5];
            //loop
            for(int teller = 0;teller < lijst.Length ; teller++)
            {
                char invoer = input[teller];
                String uitvoer = invoer.ToString();
                Console.WriteLine("het "+(teller + 1)+"de getal is "+ uitvoer);
            }
            Console.Read();
            Console.ReadKey();
        }
    }
}
