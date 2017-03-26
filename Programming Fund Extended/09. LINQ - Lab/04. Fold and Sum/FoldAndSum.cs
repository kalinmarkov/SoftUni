using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var k = input.Length / 4;
        var leftPart = input.Take(k).Reverse().ToList();
        var rightPart = input.Reverse().Take(k).ToList();

        var upperRow = leftPart.Concat(rightPart).ToArray();
        var lowerRow = input.Skip(k).Take(2 * k).ToArray();

        var result = new int[lowerRow.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = upperRow[i] + lowerRow[i];
        }

        Console.WriteLine(string.Join(" ", result));
    }
}

