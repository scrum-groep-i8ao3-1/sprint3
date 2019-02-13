using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp1

{

    class Program

    {
        //Gemaakt door Tom
        //Getest door Jairo

        static Random r = new Random();

        static void Main(string[] args)

        {
            //Een loop die 100 keer herhaald
            for (int i = 0; i < 100; i++)

            {
                //kiest een random getal voor getal1
                long getal1 = r.Next(int.MaxValue);

                //kiest een random getal voor getal1
                long getal2 = r.Next(int.MaxValue);

                //Doet product1 keer product2 en laat de uitkomst zien
                long product = getal1 * getal2;
                Console.WriteLine(product);

            }

            Console.ReadKey();

        }
    }
}