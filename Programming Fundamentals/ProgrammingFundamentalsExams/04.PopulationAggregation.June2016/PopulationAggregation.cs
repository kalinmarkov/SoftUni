using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class PopulationAggregation
{
    static void Main()
    {
        var townsByCountry = new SortedDictionary<string, List<string>>();
        var populationByTown = new Dictionary<string, decimal>();

        while (true)
        {
            var command = Console.ReadLine();
            if (command == "stop")
            {
                break;
            }
            var commandTokens = command.Split('\\');
            var country = RemoveBadChars(commandTokens[0]);
            var town = RemoveBadChars(commandTokens[1]);
            if (!char.IsUpper(country[0]))
            {
                var old = country;
                country = town;
                town = old;
            }

            // Add the current town to the current country

            if (townsByCountry.ContainsKey(country))
            {
                townsByCountry[country].Add(town);
            }
            else
            {
                townsByCountry[country] = new List<string>() { town };
            }

            // Add current population to the current town

            var population = decimal.Parse(commandTokens[2]);
            if (populationByTown.ContainsKey(town))
            {
                populationByTown[town] = population;
            }
            else
            {
                populationByTown[town] = population;
            }
        }

        foreach (var countryAndTown in townsByCountry)
        {
            Console.WriteLine("{0} -> {1}", countryAndTown.Key, countryAndTown.Value.Count);
        }

        var top3population = populationByTown.OrderByDescending(p => p.Value).Take(3);

        foreach (var p in top3population)
        {
            Console.WriteLine("{0} -> {1}", p.Key, p.Value);
        }
    }

    private static string RemoveBadChars(string str)
    {
        var validCharsOnly = str.Split("@#$&0123456789".ToArray());
        var combined = string.Concat(validCharsOnly);
        return combined;
    }
}

