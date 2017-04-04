using System;
using System.Collections.Generic;
using System.Linq;

class LINQuistics
{
    static void Main()
    {
        //  90/100
        var methodsCollection = new Dictionary<string, HashSet<string>>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "exit")
            {
                break;
            }

            if (input.Contains("."))
            {
                var tokens = input.Split(new char[] { '.', ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
                var collection = tokens[0];
                if (!methodsCollection.ContainsKey(collection))
                {
                    methodsCollection[collection] = new HashSet<string>();
                }
                for (int i = 1; i < tokens.Length; i++)
                {
                    methodsCollection[collection].Add(tokens[i]);
                }
            }
            else
            {
                var number = 0;
                if (int.TryParse(input, out number))
                {
                    foreach (var methodName in methodsCollection.Values
                        .OrderByDescending(x => x.Count()).First()
                        .OrderBy(x => x.Length).Take(number))
                    {
                        Console.WriteLine($"* {methodName}");
                    }
                }
                else if (methodsCollection.ContainsKey(input))
                {
                    var result = methodsCollection[input]
                        .OrderByDescending(x => x.Length)
                        .ThenByDescending(x => x.Distinct().Count())
                        .ToList();
                    foreach (var methodName in result)
                    {
                        Console.WriteLine($"* {methodName}");
                    }
                }
            }
            
        }

        var inputCommand = Console.ReadLine().Split();
        var method = inputCommand[0];
        var selection = inputCommand[1];

        if (selection == "all")
        {
            foreach (var collection in methodsCollection.Where(x => x.Value.Contains(method))
                .OrderByDescending(x => x.Value.Count())
                .ThenByDescending(x => x.Value.Min(y => y.Length)))
            {
                Console.WriteLine(collection.Key);
                foreach (var methodName in collection.Value.OrderByDescending(x => x.Count()))
                {
                    Console.WriteLine($"* {methodName}");
                }
            }
        }
        else
        {
            foreach (var collection in methodsCollection.Where(x => x.Value.Contains(method))
                .OrderByDescending(x => x.Value.Count())
                .ThenByDescending(x => x.Value.Min(y => y.Length)))
            {
                Console.WriteLine(collection.Key);
            }
        }
    }
}

