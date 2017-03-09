using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var count = new SortedDictionary<decimal, int>();

            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }

            foreach (var i in count.Keys)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", i, count[i]);
                }
            }

        }
    }
}
