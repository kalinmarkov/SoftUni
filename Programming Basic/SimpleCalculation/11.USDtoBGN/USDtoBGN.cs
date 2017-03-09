using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            var usd = decimal.Parse(Console.ReadLine());
            var bgn = usd * 1.79549m;
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
