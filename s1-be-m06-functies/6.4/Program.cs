using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    //danny
    //14-12-2018//
    //nakijk test 1 door timur : fout null pointer
    //nakijk test 2 door tom : fout komma getallen.
    //nakijk test 3 door tom : goed comma getalen werken
    //nakijk test 4 door jairo : werk niet met lange comma getalen (wiskundige notatie 1,37777777777778E+26)
    /*
     *
     Opdracht 6.4 (*) 

Schrijf een methode Calculate die als resultaat de uitkomst van een berekening geeft. De methode moet 3 parameters hebben: 

De eerste parameter is voor het eerste getal. Dit getal kan ook decimalen bevatten 

De tweede parameter is voor het tweede getal en kan ook decimalen bevatten. 

De derde parameter is één enkel teken (char) dat aangeeft welke berekening uitgevoerd dient te worden: 

+ : de som va de getallen 

- : het verschil tussen beide getallen 

* : het product van beide getallen 

/ : het quotiënt (eerste getal gedeeld door tweede getal; denk eraan: delen door nul blijft flauwekul) 

% : het restant van eerste getal gedeeld door tweede getal (delen door nul is???)
*/
    class Program
    {
        static void Main(string[] args)
        {
            //vraagt de berekening
            Console.WriteLine("wat is u berekening (3 tekens)(de delers die u kunt gebruiken zijn +,-,*,/)");
            Console.WriteLine("voorbeeld : 1 * 1");
            String src = Console.ReadLine();
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
                if (src.Length <= 2 )
                {
                    //(array[i].trim().length() == 0))
                    Console.WriteLine("voer een geldige reeks in");
                    Console.ReadKey();
                }
                else
                {
                    //splits de string in meerdere delen
                    string[] splits = src.Split(' ');
                    // pakt arg 1
                    string GetalEenString = splits[0];
                    // pakt arg 2
                    string Deler = splits[1];
                    // pakt arg 3
                    string GetalTweeString = splits[2];
                    // converteerd arg 1
                    double Getaleen = Convert.ToDouble(GetalEenString);
                    // converteerd arg 2
                    double Getaltwee = Convert.ToDouble(GetalTweeString);
                    // zend data naar de methode
                    Berekening( Getaleen, Getaltwee, Deler);
                }
            }
        }
        static void Berekening(double getaleen, double getaltwee, string deler)
        {
            //voert alle berekeningen uit
            if (deler == "*")
            {
                Double antwoord = getaleen * getaltwee;
                Console.WriteLine("het antwoord is " + antwoord);
                Console.ReadKey();
                return;

            }
            else if (deler == "/")
            {
                double antwoord = getaleen / getaltwee;
                Console.WriteLine("het antwoord is " + antwoord);
                Console.ReadKey();
                return;
            }
            else if (deler == "+")
            {
                double antwoord = getaleen + getaltwee;
                Console.WriteLine("het antwoord is " + antwoord);
                Console.ReadKey();
                return;
            }
            else if (deler == "-")
            {
                double antwoord = getaleen - getaltwee;
                Console.WriteLine("het antwoord is " + antwoord);
                Console.ReadKey();
                return;
            } else if(deler == "%")
            {
                double antwoord = getaleen % getaltwee;
                Console.WriteLine("het antwoord is " + antwoord);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("geef een geldige calculator in : /*-+");
                Console.ReadKey();
                return;
            }

        }
    }
}
