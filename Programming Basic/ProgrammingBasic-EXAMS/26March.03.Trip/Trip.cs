using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26March._03.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    Console.WriteLine("Camp - {0:f2}", budget * 0.3m);
                }
                else
                {
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.7m);
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");

                if (season == "summer")
                {
                    Console.WriteLine("Camp - {0:f2}", budget * 0.4m);
                }
                else
                {
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.8m);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", budget * 0.9m);
            }
        }
    }
}
