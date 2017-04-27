using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniKaraoke
{
    static void Main()
    {
        var participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

        var songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();

        var participantsResult = new Dictionary<string, SortedSet<string>>();
        
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "dawn")
            {
                break;
            }

            var tokens = input.Split(',').Select(x => x.Trim()).ToList();

            var participant = tokens[0];
            var song = tokens[1];
            var award = tokens[2];


            if (participants.Contains(participant) && songs.Contains(song))
            {

                if (!participantsResult.ContainsKey(participant))
                {
                    participantsResult[participant] = new SortedSet<string>();
                }

                participantsResult[participant].Add(award);
            }
            
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