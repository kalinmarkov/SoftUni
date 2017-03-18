using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LetterRepetition
{
    static void Main()
    {
        var input = Console.ReadLine();
        var symbolCounter = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!symbolCounter.ContainsKey(input[i]))
            {
                symbolCounter.Add(input[i], 1);
            }
            else
            {
                symbolCounter[input[i]]++;
            }
        }

        foreach (var item in symbolCounter)
        {
            var symbol = item.Key;
            var count = item.Value;

            Console.WriteLine($"{symbol} -> {count}");
        }
    }
}

