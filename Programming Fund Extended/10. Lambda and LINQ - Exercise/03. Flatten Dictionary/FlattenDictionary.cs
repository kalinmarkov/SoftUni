using System;
using System.Collections.Generic;
using System.Linq;


class FlattenDictionary
{
    static void Main()
    {
        var dataStorage = new Dictionary<string, Dictionary<string, string>>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split().ToArray();

            if (tokens[0] != "flatten")
            {
                var key = tokens[0];            
                var innerKey = tokens[1];
                var innerValue = tokens[2];

                if (!dataStorage.ContainsKey(key))
                {
                    dataStorage[key] = new Dictionary<string, string>();
                }

                dataStorage[key][innerKey] = innerValue;                
            }
            else
            {
                var key = tokens[1];
                dataStorage[key] = dataStorage[key].ToDictionary(x => x.Key + x.Value, x => "flatten");
            }

        }

        foreach (var data in dataStorage.OrderByDescending(x => x.Key.Length))
        {
            var keyWord = data.Key;
            Console.WriteLine($"{keyWord}");
            var orderedInnerDictionary = data.Value.Where(x => x.Value != "flatten").OrderBy(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);
            var count = 1;
            foreach (var item in orderedInnerDictionary)
            {
                var innerKey = item.Key;
                var innerValue = item.Value;
                Console.WriteLine($"{count}. {innerKey} - {innerValue}");
                count++;
            }

            foreach (var item in data.Value.Where(x => x.Value == "flatten"))
            {
                var innerKey = item.Key;
                Console.WriteLine($"{count}. {innerKey}");
                count++;
            }
        }
    }
}

