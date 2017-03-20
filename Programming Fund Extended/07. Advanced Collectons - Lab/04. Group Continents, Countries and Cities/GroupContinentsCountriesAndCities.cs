using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GroupContinentsCountriesAndCities
{
    static void Main()
    {
        var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var continent = input[0];
            var country = input[1];
            var city = input[2];

            if (!data.ContainsKey(continent))
            {
                data[continent] = new SortedDictionary<string, SortedSet<string>>();
            }

            if (!data[continent].ContainsKey(country))
            {
                data[continent][country] = new SortedSet<string>();
            }

            data[continent][country].Add(city);
        }

        foreach (var continents in data)
        {
            var continent = continents.Key;
            var citiesByCountry = continents.Value;
            Console.WriteLine($"{continent}:");

            foreach (var countries in citiesByCountry)
            {
                var country = countries.Key;
                var city = countries.Value;
                Console.WriteLine($"  {country} -> {string.Join(", ",city)}");
            }
        }
    }
}

