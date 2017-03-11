using System;
using System.Linq;

class AverageCharacterDelimiter
{
    static void Main()
    {
        var input = Console.ReadLine();
        var arr = input
            .Split()
            .ToArray();

        var count = 0;

        var sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                count++;
                sum += input[i];
            }
        }       

        double average = Math.Floor((double)sum / count);

        var symbol = (char)average;
        var separateSymbol = symbol.ToString().ToUpper();

        Console.WriteLine(string.Join($"{separateSymbol}", arr));
    }
}

