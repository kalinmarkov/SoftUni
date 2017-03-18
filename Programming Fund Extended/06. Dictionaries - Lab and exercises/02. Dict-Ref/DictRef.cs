using System;
using System.Collections.Generic;
using System.Linq;

class DictRef
{
    static void Main()
    {
        var names = new Dictionary<string, int>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var name = tokens[0];
            var value = 0;

            if (int.TryParse(tokens[1], out value))
            {
                names[name] = value;
            }
            else
            {
                if (names.ContainsKey(tokens[1]))
                {
                    var temp = names[tokens[1]];
                    names[name] = temp; 
                }
            }
            
        }

        foreach (var pair in names)
        {
            Console.WriteLine($"{pair.Key} === {pair.Value}");
        }
    }
}

