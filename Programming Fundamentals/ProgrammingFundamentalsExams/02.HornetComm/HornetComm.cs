using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class HornetComm
{
    static void Main()
    {
        //var key = @"(<->)";
        //key = Regex.Escape(key);

        var regexMes = new Regex($@"([\d|]+|<\+?\-?>\.<\+?\-?>)\s+(<->)\s+([\w\d].*)");
        var regexBro = new Regex($@"([\w\d].*)\s+(<->)\s+([\d|]+|<\+?\-?>\.<\+?\-?>)");

        var messages = new Dictionary<string, string>();
        var broadcast = new Dictionary<string, string>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "Hornet is Green")
            {
                break;
            }

            var matchMes = regexMes.Match(input);

            var recipient = matchMes.Groups[1].Value;
            var recipientMessage = matchMes.Groups[3].Value;

            if (matchMes.Success)
            {
                // o	{recipient} -> {message}


                if (!messages.ContainsKey(recipient))
                {
                    messages.Add(recipient, recipientMessage);
                }
                else
                {
                    messages[recipient] = recipientMessage;
                }
            }

            var matchBro = regexBro.Match(input);

            var frequency = matchBro.Groups[1].Value;
            var frequencyMessage = matchBro.Groups[3].Value;

            if (matchBro.Success)
            {
                // o	{frequency} -> {message}


                if (!broadcast.ContainsKey(frequency))
                {
                    broadcast.Add(frequency, frequencyMessage);
                }
                else
                {
                    broadcast[frequency] = frequencyMessage;
                }
            }

            if (!matchBro.Success && !matchMes.Success)
            {
                Console.WriteLine("None");
                break;
            }

        }



        Console.WriteLine("Broadcasts:");
        foreach (var pair in broadcast)
        {
            Console.WriteLine($"{pair.Value} -> {pair.Key}");
        }

        Console.WriteLine("Messages:");
        foreach (var pair in messages)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}

