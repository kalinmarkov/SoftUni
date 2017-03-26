using System;
using System.Collections.Generic;
using System.Linq;

class DefaultValues
{
    static void Main()
    {
        var dataStorage = new Dictionary<string, string>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var wordKey = tokens[0];
            var wordValue = tokens[1];

            dataStorage[wordKey] = wordValue;
        }

        var defaultValue = Console.ReadLine();

        foreach (var word in dataStorage.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length))
        {
            Console.WriteLine($"{word.Key} <-> {word.Value}");
        }

        foreach (var word in dataStorage.Where(x => x.Value == "null"))
        {
            Console.WriteLine($"{word.Key} <-> {defaultValue}");
        }
    }
}

