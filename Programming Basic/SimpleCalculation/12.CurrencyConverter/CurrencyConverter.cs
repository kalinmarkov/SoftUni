using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value: ");
            var value = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Input currency: ");
            var currency1 = Console.ReadLine();
            Console.WriteLine("Output currency: ");
            var currency2 = Console.ReadLine();

            if (currency1 == "USD" && currency2 == "BGN")
            {
                var result = value * 1.79549m;
                Console.WriteLine(Math.Round(result, 2));
            }
            else if (currency1 == "BGN" && currency2 == "EUR")
            {
                var result = value / 1.95583m;
                Console.WriteLine(Math.Round(result, 2));
            }
            else if (currency1 == "EUR" && currency2 == "GBP")
            {
                var result = value * 1.95583m / 2.53405m;
                Console.WriteLine(Math.Round(result, 2));
            }
            else if (currency1 == "USD" && currency2 == "EUR")
            {
                var result = value * 1.79549m / 1.95583m;
                Console.WriteLine(Math.Round(result, 2));
            }
            else if (currency1 == "GBP" && currency2 == "USD")
            {
                var result = value * 2.53405m / 1.79549m;
                Console.WriteLine(Math.Round(result, 2));
            }         
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
