using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WormsWorldParty
{
    static void Main()
    {
        var wormsByTeam = new Dictionary<string, Dictionary<string, long>>();

        var listOfNames = new List<string>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            var tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var wormName = tokens[0];
            var wormTeam = tokens[1];
            var wormScore = long.Parse(tokens[2]);

            if (listOfNames.Contains(wormName))
            {
                continue;
            }
            listOfNames.Add(wormName);


            if (!wormsByTeam.ContainsKey(wormTeam))
            {
                wormsByTeam[wormTeam] = new Dictionary<string, long>();
            }
            
            if (!wormsByTeam[wormTeam].ContainsKey(wormName))
            {
                wormsByTeam[wormTeam][wormName] = wormScore;
            }
            else
            {
                continue;
            }
                        
        }        

        var count = 1;
        foreach (var team in wormsByTeam
            .OrderByDescending(s => s.Value.Values.Sum())
            .ThenByDescending(s => s.Value.Values.Average()))
        {
            var teamName = team.Key;
            var teamScore = team.Value.Values.Sum();
            Console.WriteLine($"{count++}. Team: {teamName} - {teamScore}");

            foreach (var worm in team.Value.OrderByDescending(s => s.Value))
            {
                var wormName = worm.Key;
                var wormScore = worm.Value;
                Console.WriteLine($"###{wormName} : {wormScore}");
            }
        }

    }
}

