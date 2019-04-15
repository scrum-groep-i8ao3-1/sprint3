using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class csharpExercise
{
    static void Main(string[] args)
    {

        int basenumber, exponent, power, i;

        // Reading number
        Console.Write("voer een nummer in: ");
        basenumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("voer een nummer in: ");
        exponent = Convert.ToInt32(Console.ReadLine());

        power = 1;
        i = 1;
       //caluclatie
        while (i <= exponent)
        {
            power = power * basenumber;
            i++;
        }
        Console.Write("Power : " + power);

        Console.ReadLine();
    }
}