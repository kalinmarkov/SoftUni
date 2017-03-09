using System;
using System.Text.RegularExpressions;

class ExtractSentencesByKeyword
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var text = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        var pattern = "\\b" + input + "\\b";

        var rgx = new Regex(pattern);

        for (int i = 0; i < text.Length; i++)
        {
            if (rgx.IsMatch(text[i]))
            {
                Console.WriteLine(text[i].Trim());
            }
        }
    }
}

