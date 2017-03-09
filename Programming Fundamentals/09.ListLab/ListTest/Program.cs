using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        nums.Sort();

        var countNumbers = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!countNumbers.ContainsKey(num))
            {
                countNumbers[num] = 1;
            }
            else
            {
                countNumbers[num]++;
            }
        }

        foreach (var pair in countNumbers)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

