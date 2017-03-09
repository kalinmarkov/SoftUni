using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class FootballLeague
{
    static void Main()
    {
        var key = Console.ReadLine();
        key = Regex.Escape(key);

        var regex = new Regex($@"{key}(.*?){key}.*?{key}(.*?){key}.*?(\d+):(\d+)");

        var score = new Dictionary<string, long>();
        var goals = new Dictionary<string, long>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "final")
            {
                break;
            }

            var match = regex.Match(input);

            var firstTeam = new string(match.Groups[1].Value.Reverse().ToArray()).ToUpper();
            var secondTeam = new string(match.Groups[2].Value.Reverse().ToArray()).ToUpper();
            var firstTeamGoals = int.Parse(match.Groups[3].Value);
            var secondTeamGoals = int.Parse(match.Groups[4].Value);

            if (!score.ContainsKey(firstTeam))
            {
                score[firstTeam] = 0;
            }

            if (!score.ContainsKey(secondTeam))
            {
                score[secondTeam] = 0;
            }

            if (!goals.ContainsKey(firstTeam))
            {
                goals[firstTeam] = 0;
            }

            if (!goals.ContainsKey(secondTeam))
            {
                goals[secondTeam] = 0;
            }

            goals[firstTeam] += firstTeamGoals;
            goals[secondTeam] += secondTeamGoals;

            if (firstTeamGoals > secondTeamGoals)
            {
                score[firstTeam] += 3;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                score[secondTeam] += 3;
            }
            else
            {
                score[firstTeam]++;
                score[secondTeam]++;
            }
            
        }

        Console.WriteLine("League standings:");

        int place = 1;
        foreach (var kvp in score.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
        {
            Console.WriteLine($"{place}. {kvp.Key} {kvp.Value}");
            place++;
        }

        Console.WriteLine("Top 3 scored goals:");
        foreach (var kvp in goals.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).Take(3))
        {
            Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
        }
    }
}

