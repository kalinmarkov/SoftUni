using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SoftUniKaraoke
{

    public static void Main()
    {
        List<string> participants = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToList();

        List<string> songs = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToList();

        Dictionary<string, SortedSet<string>> participantsResult = new Dictionary<string, SortedSet<string>>();

        List<string> input = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToList();


        while (!input[0].Equals("dawn"))
        {
            var participant = input[0];
            var song = input[1];
            var award = input[2];


            if (!participants.Any(x => x.Equals(participant)) || !songs.Any(x => x.Equals(song)))
            {
                input = Console.ReadLine()
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToList();
                continue;
            }

            if (participantsResult.ContainsKey(participant))
            {
                participantsResult[participant].Add(award);
            }
            else
            {
                participantsResult[participant] = new SortedSet<string>()
                    {
                        award
                    };
            }

            input = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToList();
        }

        if (participantsResult.Count == 0)
        {
            Console.WriteLine("No awards");
        }

        foreach (var participant in participantsResult.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
            foreach (var award in participant.Value)
            {
                Console.WriteLine($"--{award}");
            }
        }
    }
}

