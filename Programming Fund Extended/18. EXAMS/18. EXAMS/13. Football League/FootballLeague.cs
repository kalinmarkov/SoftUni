﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Score
{
    public decimal Points { get; set; }

    public decimal Goals { get; set; }
}

class FootballLeague
{
    static void Main()
    {
        var key = Regex.Escape(Console.ReadLine());

        var pattern = $@"^.*(?:{key})(?<team1>[a-zA-Z]*)(?:{key}).*\s.*(?:{key})(?<team2>[a-zA-Z]*)(?:{key}).*\s(?<team1Score>\d+):(?<team2Score>\d+).*$";

        var teamScores = new Dictionary<string, Score>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "final")
            {
                break;
            }

            var match = Regex.Match(input, pattern);

            if (!match.Success)
            {
                continue;
            }

            var team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
            var team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
            var team1Goals = int.Parse(match.Groups["team1Score"].Value);
            var team2Goals = int.Parse(match.Groups["team2Score"].Value);

            if (!teamScores.ContainsKey(team1Name))
            {
                teamScores[team1Name] = new Score();
            }

            if (!teamScores.ContainsKey(team2Name))
            {
                teamScores[team2Name] = new Score();
            }

            if (team1Goals > team2Goals)
            {
                teamScores[team1Name].Points += 3;
            }
            else if (team1Goals == team2Goals)
            {
                teamScores[team1Name].Points++;
                teamScores[team2Name].Points++;
            }
            else
            {
                teamScores[team2Name].Points += 3;
            }

            teamScores[team1Name].Goals += team1Goals;
            teamScores[team2Name].Goals += team2Goals;
        }

        Console.WriteLine("League standings:");

        var leagueStandings = teamScores.OrderByDescending(a => a.Value.Points).ThenBy(a => a.Key);

        var place = 1;
        foreach (var leagueStanding in leagueStandings)
        {
            var teamName = leagueStanding.Key;
            var teamPoints = leagueStanding.Value.Points;

            Console.WriteLine($"{place++}. {teamName} {teamPoints}");
        }

        Console.WriteLine("Top 3 scored goals:");

        var top3Goals = teamScores.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3);
        foreach (var teamGoals in top3Goals)
        {
            var teamName = teamGoals.Key;
            var goals = teamGoals.Value.Goals;

            Console.WriteLine($"- {teamName} -> {goals}");
        }
    }
}

