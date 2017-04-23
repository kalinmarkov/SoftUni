using System;
using System.Collections.Generic;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        var words = Console.ReadLine().Split(new[] { ' ', ',', '.', '!', '?', ':' }, StringSplitOptions.RemoveEmptyEntries);
        var palindromes = new SortedSet<string>();

        foreach (var word in words)
        {
            var leftPart = word.Substring(0, word.Length / 2);
            var startIndex = word.Length % 2 == 0 ? word.Length / 2 : word.Length / 2 + 1;
            var rightPart = string.Join("", word.Substring(startIndex).ToCharArray().Reverse());

            if (leftPart.Equals(rightPart))
            {
                palindromes.Add(word);
            }
        }

        Console.WriteLine(string.Join(", ", palindromes));
    }
}

