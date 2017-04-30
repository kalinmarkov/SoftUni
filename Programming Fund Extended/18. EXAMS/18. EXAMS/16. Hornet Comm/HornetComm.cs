using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class HornetComm
{
    static void Main()
    {
        var message = new List<string>();
        var breadcast = new List<string>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "Hornet is Green")
            {
                break;
            }

            var tokens = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length != 2)
            {
                continue;
            }

            var firstQuery = tokens[0];
            var secondQuery = tokens[1];

            if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
            {
                var reversedQuery = new string(firstQuery.Reverse().ToArray());

                message.Add($"{reversedQuery} -> {secondQuery}");
            }
            else if (firstQuery.All(s => !char.IsDigit(s)) && secondQuery.All(char.IsLetterOrDigit))
            {
                var transformed = new StringBuilder();

                foreach (var symbol in secondQuery)
                {
                    if (char.IsUpper(symbol))
                    {
                        transformed.Append(symbol.ToString().ToLower());
                    }
                    else if (char.IsLower(symbol))
                    {
                        transformed.Append(symbol.ToString().ToUpper());
                    }
                    else
                    {
                        transformed.Append(symbol);
                    }
                }

                breadcast.Add($"{transformed} -> {firstQuery}");
            }
        }

        Console.WriteLine("Broadcasts:");
        Console.WriteLine(breadcast.Any() ? string.Join(Environment.NewLine, breadcast) : "None");

        Console.WriteLine("Messages:");
        Console.WriteLine(message.Any() ? string.Join(Environment.NewLine, message) : "None");
    }
}

