using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            var bgnPriceVeg = float.Parse(Console.ReadLine());
            var bgnPriceFruit = float.Parse(Console.ReadLine());
            var weightVeg = int.Parse(Console.ReadLine());
            var weightFruit = int.Parse(Console.ReadLine());

            var euro1 = bgnPriceVeg / 1.94;
            var euro2 = bgnPriceFruit / 1.94;

            var bill1 = euro1 * weightVeg;
            var bill2 = euro2 * weightFruit;

            Console.WriteLine(bill1 + bill2);

        }
    }
}
