using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Shellbound
{
    static void Main()
    {
        var shellbound = new Dictionary<string, HashSet<int>>();

        while (true)
        {
            var input = Console.ReadLine().Split();
            if (input[0] == "Aggregate")
            {
                break;
            }

            var town = input[0];
            var shellSize = int.Parse(input[1]);

            if (!shellbound.ContainsKey(town))
            {
                shellbound[town] = new HashSet<int>();
            }

            shellbound[town].Add(shellSize);
        }

        foreach (var element in shellbound)
        {
            var town = element.Key;
            var shellSize = string.Join(", ", element.Value);
            var aggregate = element.Value.Sum() - element.Value.Sum() / element.Value.Count;

            Console.WriteLine($"{town} -> {shellSize} ({aggregate})");
        }
    }
}

