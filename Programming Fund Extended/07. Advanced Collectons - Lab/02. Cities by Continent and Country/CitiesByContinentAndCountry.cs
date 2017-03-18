using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CitiesByContinentAndCountry
{
    static void Main()
    {
        var continentList = new Dictionary<string, Dictionary<string, List<string>>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var continent = input[0];
            var country = input[1];
            var city = input[2];
            AddCity(continentList, continent, country, city);

        }

        foreach (var continent in continentList.Keys)
        {
            Console.WriteLine($"{continent}:");
            var countryInContinent = continentList[continent];
            foreach (var country in countryInContinent.Keys)
            {
                var cities = countryInContinent[country];
                Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
            }
        }
    }

    private static void AddCity(Dictionary<string, Dictionary<string, List<string>>> continentList, string continent, string country, string city)
    {
        if (!continentList.ContainsKey(continent))
        {
            continentList[continent] = new Dictionary<string, List<string>>();
        }
        if (!continentList[continent].ContainsKey(country))
        {
            continentList[continent][country] = new List<string>();
        }

        continentList[continent][country].Add(city);
    }
}

