using System;
using System.Collections.Generic;
using System.Linq;

public class JSONParse
{
    public static void Main()
    {
        var input = Console.ReadLine();
        input = input.Remove(0, 1);
        input = input.Remove(input.Length - 1);

        var tokens = input.Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < tokens.Length; i += 2)
        {
            var currentJSONArgs = tokens[i]
                .Split(":\",[]".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = currentJSONArgs[1];
            var age = int.Parse(currentJSONArgs[3]);
            var grades = currentJSONArgs.Length > 2 ?
                currentJSONArgs.Skip(5).ToList() :
                new List<string>();

            var gradesToString = grades.Any() ? string.Join(",", grades) : "None";

            Console.WriteLine($"{name} : {age} -> {gradesToString}");
        }
    }
}