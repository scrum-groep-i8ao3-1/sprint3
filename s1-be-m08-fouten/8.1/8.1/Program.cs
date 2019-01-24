using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //gemaakt door tom/danny // getest door tom/danny
            //vraagt input
            Console.WriteLine("geef een invoer naar keuze");
            //variabelen maken
            String input = Console.ReadLine();
            bool containsLetter = Regex.IsMatch(input, "[a-zA-Z]");
            if (containsLetter == false)
            {
                Console.Write("getal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("fout");
                Console.ReadLine();
            }

        }

    }
}
