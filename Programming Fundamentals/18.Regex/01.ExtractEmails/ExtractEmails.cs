using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        var text = Console.ReadLine();

        // var pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
        var pattern = @"([\w-.]+\@[\w]+)(\.[\w]+)+"; 
        var rgx = new Regex(pattern);
        var matches = rgx.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

