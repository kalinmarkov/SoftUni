using System;
using System.Collections.Generic;

class Website
{
    public string Host { get; set; }

    public string Domain { get; set; }

    public List<string> Query { get; set; }
}

class Websites
{
    static void Main()
    {
        var webDB = new List<Website>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split(" |,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var host = tokens[0];
            var domain = tokens[1];
            var query = new List<string>();

            for (int i = 2; i < tokens.Length; i++)
            {
                query.Add(tokens[i]);
            }

            var newWebsite = new Website
            {
                Host = host,
                Domain = domain,
                Query = query
            };

            webDB.Add(newWebsite);
        }

        foreach (var web in webDB)
        {
            var host = web.Host;
            var domain = web.Domain;
            var query = web.Query;

            if (query.Count < 1)
            {
                Console.WriteLine($"https://www.{host}.{domain}");
            }
            else
            {
                Console.WriteLine($"https://www.{host}.{domain}/query?=[{string.Join("]&[", query)}]");
            }
        }
    }
}

