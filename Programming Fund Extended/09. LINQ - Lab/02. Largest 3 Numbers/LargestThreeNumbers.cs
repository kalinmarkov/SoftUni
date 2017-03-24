using System;
using System.Linq;

class LargestThreeNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        numbers.Sort();
        numbers.Reverse();

        var result = numbers.Take(3);
        Console.WriteLine(string.Join(" ",result));

    }
}

