using System;
using System.Linq;

class SentenceSplit
{
    static void Main()
    {
        var text = Console.ReadLine();
        var delimeter = Console.ReadLine();

        var sentences = text
            .Split(new string[] { delimeter }, StringSplitOptions.None)
            .ToArray();

        Console.WriteLine($"[{string.Join(", ", sentences)}]");
    }
}

