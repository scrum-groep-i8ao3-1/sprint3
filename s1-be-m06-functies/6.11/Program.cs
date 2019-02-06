using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    //Timur
    //28-1-2019//
    /*
     *
     Opdracht 6.11 (*) 

Schrijf een methode Calculate die als resultaat de uitkomst van een berekening geeft het is een vervolg van 6.4. De methode moet 2 parameters hebben: 

De eerste parameter is voor het eerste getal. Dit getal kan ook decimalen bevatten 

De tweede parameter is voor het tweede getal en kan ook decimalen bevatten.  

dit zijn de berekeningen die plaats vinden: 
+ : de som va de getallen 

- : het verschil tussen beide getallen 

* : het product van beide getallen 

/ : het quotiënt (eerste getal gedeeld door tweede getal; denk eraan: delen door nul blijft flauwekul) 

% : het restant van eerste getal gedeeld door tweede getal (delen door nul is???)
*/
    class Program
    {
        static void Berekening (double getaleen, double getaltwee, out string answer)
        {
                //voert alle berekeningen uit
             
            Console.WriteLine("het antwoord is " + getaleen * getaltwee);
            Console.WriteLine("het antwoord is " + getaleen / getaltwee);
            Console.WriteLine("het antwoord is " + getaleen + getaltwee);
            Console.WriteLine("het antwoord is " + (getaleen - getaltwee));
            Console.WriteLine("het antwoord is " + getaleen % getaltwee);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            //vraagt de berekening
            Console.WriteLine("voer 2 getalen in en de wat je met de getallen wil doen kies uit (/,*,+,-) ");
            Console.WriteLine("voorbeeld : 13 + 16");
            string src = Convert.ToString(Console.ReadLine());
            // zend data naar de methode
            obj.Berekening(Getaleen, Getaltwee, out teken);

            // kijkt of er spaties in de string zitten
            if (!(src.Contains(" ")))
            {
                Console.WriteLine("voeg spaties toe!");
                Console.ReadKey();
            }
            else
            {
                //slaat de berekening op als input berekening
                //voorbeeld 1 * 1 +
                //args      0 1 2
                //checkt de lengte van de string (src variable)
                if (src.Length <= 2)
                {
                    //(array[i].trim().length() == 0))
                    Console.WriteLine("voer een geldige reeks in");
                    Console.ReadKey();
                }
            }
        }


        }
    }

