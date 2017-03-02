using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26March._01.VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            decimal priceVeg = decimal.Parse(Console.ReadLine());
            decimal priceFruit = decimal.Parse(Console.ReadLine());
            int weightVeg = int.Parse(Console.ReadLine());
            int weightFruit = int.Parse(Console.ReadLine());

            decimal sum = (priceVeg * weightVeg / 1.94m) + (priceFruit * weightFruit /1.94m);
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
