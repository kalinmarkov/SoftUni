﻿using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main()
    {
        var input = Console.ReadLine();

        var regex = new Regex(@"(\D+)(\d+)");

        var matches = regex.Matches(input);

        var result = new StringBuilder();

        foreach (Match match in matches)
        {
            var partition = match.Groups[1].Value;
            var times = int.Parse(match.Groups[2].Value);

            result.Append(Repeat(partition, times).ToUpper());
        }

        var count = result.ToString().Distinct().Count();

        Console.WriteLine($"Unique symbols used: {count}");
        Console.WriteLine(result);
    }

    private static string Repeat(string partition, int times)
    {
        var final = new StringBuilder();

        for (int i = 0; i < times; i++)
        {
            final.Append(partition);
        }

        return final.ToString();
    }
}

