using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var counter = new SortedDictionary<double, int>();

        foreach (var num in input)
        {
            if (!counter.ContainsKey(num))
            {
                counter[num] = 1;
            }
            else
            {
                counter[num]++;
            }
        }

        foreach (var pair in counter)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

