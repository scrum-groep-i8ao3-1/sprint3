using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    //danny
    //20
    //niet gebeurd
    //14-12-2018
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een datum in als : d/mm/yyyy");
            string input = Console.ReadLine();
            string createddate = Convert.ToDateTime(input).ToString("MM");
            CultureInfo MyCultureInfo = new CultureInfo("nl");
            DateTime MyDateTime = DateTime.Parse(input, MyCultureInfo);
            Console.WriteLine(MyDateTime);
            Console.ReadLine();
            // The example displays the following output:
            //       6/12/2008 12:00:00 AM
        }
        public static void zodiac()
        {

        }
    }
}
