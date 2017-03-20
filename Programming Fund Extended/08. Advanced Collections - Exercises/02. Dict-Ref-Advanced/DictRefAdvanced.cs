using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DictRefAdvanced
{
    static void Main()
    {
        var data = new Dictionary<string, List<int>>();

        while (true)
        {
            var input = Console.ReadLine().Split(", ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (input[0] == "end")
            {
                break;
            }

            var currentKey = input[0];

            var value = 0;
            if (int.TryParse(input[1], out value))
            {
                if (!data.ContainsKey(currentKey))
                {
                    data[currentKey] = new List<int>();
                }

                for (int i = 1; i < input.Length; i++)
                {
                    data[currentKey].Add(int.Parse(input[i]));

                }
            }
            else
            {
                var otherKey = input[1];
                if (data.ContainsKey(otherKey))
                {
                    data[currentKey] = new List<int>(data[otherKey]);

                }
            }

        }

        foreach (var item in data)
        {
            var name = item.Key;
            var values = string.Join(", ", item.Value);
            Console.WriteLine($"{name} === {values}");
        }
    }
}

