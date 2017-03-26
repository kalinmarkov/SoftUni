using System;
using System.Collections.Generic;
using System.Linq;

class LambadaExpressions
{
    static void Main()
    {
        var lambdaStorage = new Dictionary<string, Dictionary<string, string>>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "lambada")
            {
                break;
            }

            var tokens = input.Split(new[] { ' ', '.', '=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (tokens.Length > 1)
            {
                var selector = tokens[0];
                var selectorObject = tokens[1];
                var property = tokens[2];

                if (!lambdaStorage.ContainsKey(selector))
                {
                    lambdaStorage[selector] = new Dictionary<string, string>();
                }

                lambdaStorage[selector][selectorObject] = property;
            }
            else
            {
                lambdaStorage = lambdaStorage
                    .ToDictionary(selector => selector.Key, 
                    selector => selector.Value.ToDictionary(selectorObj => selectorObj.Key, 
                    selectorObj => selectorObj.Key + '.' + selectorObj.Value));
            }
            
        }

        foreach (var selector in lambdaStorage)
        {
            foreach (var item in selector.Value)
            {
                var selectorObj = item.Key;
                var property = item.Value;
                Console.WriteLine($"{selector.Key} => {selectorObj}.{property}");
            }

        }
    }
}


