using System;
using System.Linq;

namespace _05.RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            foreach (var num in nums)
            {
                var rounded = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine(num + " => " + rounded);
            }
        }
    }
}
