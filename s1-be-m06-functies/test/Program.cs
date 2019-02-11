using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        public void Math1(double a, double b, out string c)
        {
            Console.WriteLine("wat is je som");
            Console.WriteLine("doe het zo: 34 + 20 ");
            String src = Console.ReadLine();
            //splits de string in meerdere delen
            string[] splits = src.Split(' ');
            // pakt arg 1
            string m = splits[0];
            // pakt arg 2
            string n = splits[2];
            // pakt arg 3 
            c = splits[1];
            // converteerd arg 1
            a = Convert.ToDouble(m);
            // converteerd arg 2
            b = Convert.ToDouble(n);
        }
        public void Main(string[] args)
        {
            double Getaleen;
            double Getaltwee;
            string p;
            double q;
            Program obj = new Program();
            obj.Math1(Getaleen, Getaltwee, out p);
   

            if (p == "*")
            {
                q = Getaleen * Getaltwee;
                Console.WriteLine(q);
                Console.ReadLine();
            }

            else if (p == "-")
            {
                q = Getaleen - Getaltwee;
                Console.WriteLine(q);
                Console.ReadLine();
            }

            else if (p == "+")
            {
                q = Getaleen + Getaltwee;
                Console.WriteLine(q);
                Console.ReadLine();

            }

            else if (p == "/")
            {
                q = Getaleen / Getaltwee;
                Console.WriteLine(q);
                Console.ReadLine();
            }

            else if (p != "-" || p != "+" ||p != "/"||p != "*")
            {
                Console.WriteLine("probeer het opnieuw met een van de keuzes die er zijn gegeven");
                Console.ReadLine();
            }
      }
    }
}

