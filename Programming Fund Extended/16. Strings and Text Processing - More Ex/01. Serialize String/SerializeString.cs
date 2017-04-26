using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var text = Console.ReadLine();
        var charCounter = new Dictionary<char, HashSet<int>>();

        for (int i = 0; i < text.Length; i++)
        {
            var pattern = text[i];
            if (!charCounter.ContainsKey(pattern))
            {
                charCounter[pattern] = new HashSet<int>();
            }

            var index = -1;

            while (true)
            {
                index = text.IndexOf(pattern, index + 1);

                if (index < 0)
                {
                    break;
                }

                charCounter[pattern].Add(index);
            }

        }

        foreach (var item in charCounter)
        {
            var pattern = item.Key;
            var indexOfPattern = string.Join("/", item.Value);
            Console.WriteLine($"{pattern}:{indexOfPattern}");
        }
    }
}

