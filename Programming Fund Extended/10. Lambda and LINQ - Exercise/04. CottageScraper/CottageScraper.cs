using System;
using System.Collections.Generic;
using System.Linq;

class CottageScraper
{
    static void Main()
    {
        var treeContainer = new Dictionary<string, List<int>>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "chop chop")
            {
                break;
            }

            var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var type = tokens[0];
            var height = int.Parse(tokens[1]);

            if (!treeContainer.ContainsKey(type))
            {
                treeContainer[type] = new List<int>();
            }

            treeContainer[type].Add(height);
        }

        var neededTypeOfTree = Console.ReadLine();
        var minLenghtOfTree = int.Parse(Console.ReadLine());

        var lenghtOfTrees = 0;
        var count = 0;

        foreach (var type in treeContainer)
        {
            foreach (var tree in type.Value)
            {
                lenghtOfTrees += tree;
                    count++;
            }
        }
        decimal pricePerMeter = Math.Round(((decimal)lenghtOfTrees / count), 2);

        var unusedLogs = 0;
        var usedLogs = 0;
        foreach (var type in treeContainer.Where(x => x.Key == neededTypeOfTree))
        {
            foreach (var tree in type.Value)
            {
                if (tree >= minLenghtOfTree)
                {
                    usedLogs += tree;
                }
                else
                {
                    unusedLogs += tree;
                }                
            }
        }
        decimal usedLogsPrice = Math.Round((usedLogs * pricePerMeter), 2);

        foreach (var type in treeContainer.Where(x => x.Key != neededTypeOfTree))
        {
            foreach (var tree in type.Value)
            {
                unusedLogs += tree;
            }
        }
        decimal unusedLogsPrice = Math.Round((unusedLogs * pricePerMeter * 0.25m), 2);

        var subTotal = Math.Round((usedLogsPrice + unusedLogsPrice), 2);

        Console.WriteLine($"Price per meter: ${pricePerMeter:0.00}");
        Console.WriteLine($"Used logs price: ${usedLogsPrice:0.00}");
        Console.WriteLine($"Unused logs price: ${unusedLogsPrice:0.00}");
        Console.WriteLine($"CottageScraper subtotal: ${subTotal:0.00}");
    }
}

