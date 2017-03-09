using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double price = -1.0;

            if (town == "Sofia")
            {
                if (0 <= sales && sales <= 500) price = 0.05;
                else if (500 < sales && sales <= 1000) price = 0.07;
                else if (1000 < sales && sales <= 10000) price = 0.08;
                else if (sales > 10000) price = 0.12;
                else
                {
                    Console.WriteLine("error");
                }   
            }

            else if (town == "Varna")
            {
                if (0 <= sales && sales <= 500) price = 0.045;
                else if (500 < sales && sales <= 1000) price = 0.075;
                else if (1000 < sales && sales <= 10000) price = 0.1;
                else if (sales > 10000) price = 0.13;
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (town == "Plovdiv")
            {
                if (0 <= sales && sales <= 500) price = 0.055;
                else if (500 < sales && sales <= 1000) price = 0.08;
                else if (1000 < sales && sales <= 10000) price = 0.12;
                else if (sales > 10000) price = 0.145;
                else
                {
                    Console.WriteLine("error");
                }
            }
         
            else if (price == -1.0)
            {
                Console.WriteLine("error");
            }
            Console.WriteLine("{0:f2}", (sales * price));
        }
    }
}
