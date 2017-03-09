using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        string text = "Nakov: 123";
        string pattern = @"([A-Z][a-z]+): (\d+)";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(text);

        Console.WriteLine(match.Groups.Count); // 3
        Console.WriteLine("Matched text: \"{0}\"", match.Groups[0]);
        Console.WriteLine("Name: {0}", match.Groups[1]); // Nakov
        Console.WriteLine("Number: {0}", match.Groups[2]); // 123

    }
}

