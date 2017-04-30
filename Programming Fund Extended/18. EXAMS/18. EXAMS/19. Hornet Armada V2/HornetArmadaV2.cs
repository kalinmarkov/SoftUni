using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class HornetArmadaV2
{
    static void Main()
    {
        var legionsWithActivity = new Dictionary<string, int>();
        var legionsWithSoldiers = new Dictionary<string, Dictionary<string, long>>();

        int n = int.Parse(Console.ReadLine());

        var inputPattern = @"(\d+)\s\=\s(.+)\s\-\>\s(.+)\:(\d+)";
        var inputRegex = new Regex(inputPattern);

        for (int i = 0; i < n; i++)
        {
            var inputMatch = inputRegex.Match(Console.ReadLine());

            var lastActivity = int.Parse(inputMatch.Groups[1].Value); //EXTRACT THE LAST ACTIVITY
            var legionName = inputMatch.Groups[2].Value; //EXTRACT THE LEGION NAME
            var soldierType = inputMatch.Groups[3].Value; //EXTRACT THE SOLDIER TYPE
            var soldierCount = int.Parse(inputMatch.Groups[4].Value); //EXTRACT THE SOLDIER COUNT

            if (!legionsWithActivity.ContainsKey(legionName))
            {
                legionsWithActivity.Add(legionName, lastActivity);
                legionsWithSoldiers.Add(legionName, new Dictionary<string, long>());
            }

            if (lastActivity > legionsWithActivity[legionName])
            {
                legionsWithActivity[legionName] = lastActivity;
            }

            if (!legionsWithSoldiers[legionName].ContainsKey(soldierType))
            {
                legionsWithSoldiers[legionName].Add(soldierType, 0);
            }

            legionsWithSoldiers[legionName][soldierType] += soldierCount;
        }

        string[] queryParams = Console.ReadLine().Split('\\');

        if (queryParams.Length > 1)
        {
            var activity = int.Parse(queryParams[0]);

            var soldierType = queryParams[1];

            foreach (var legionEntry in legionsWithSoldiers
                .Where(legion => legion.Value.ContainsKey(soldierType))
                .OrderByDescending(legion => legion.Value[soldierType]))
            {
                if (legionsWithActivity[legionEntry.Key] < activity)
                {
                    Console.WriteLine("{0} -> {1}", legionEntry.Key, legionsWithSoldiers[legionEntry.Key][soldierType]);
                }
            }
        }
        else
        {
            var soldierType = queryParams[0];

            foreach (var legionEntry in legionsWithActivity.OrderByDescending(legion => legion.Value))
            {
                if (legionsWithSoldiers[legionEntry.Key].ContainsKey(soldierType))
                {
                    Console.WriteLine("{0} : {1}", legionEntry.Value, legionEntry.Key);
                }
            }
        }
    }
}

