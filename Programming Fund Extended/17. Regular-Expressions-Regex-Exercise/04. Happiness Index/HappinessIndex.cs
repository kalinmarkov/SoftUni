using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class HappinessIndex
{
    static void Main()
    {
        var happyPattern = new Regex(@"(\:\)|\:D|\;\)|\:\*|\:\]|\;\]|\:\}|\;\}|\(\:|\*\:|c\:|\[\:|\[\;)");
        var sadPattern = new Regex(@"(\:\(|D\:|\;\(|\:\[|\;\[|\:\{|\;\{|\)\:|\:c|\]\:|\]\;)");

        var input = Console.ReadLine();

        var happyMatches = happyPattern.Matches(input);
        var sadMatches = sadPattern.Matches(input);

        int happyCount = happyMatches.Count;
        int sadCount = sadMatches.Count;

        var happyIndex = happyCount / (double)sadCount;
        var status = string.Empty;

        if (happyIndex >= 2)
        {
            status = ":D";
        }
        else if (happyIndex > 1)
        {
            status = ":)";
        }
        else if (happyIndex == 1)
        {
            status = ":|";
        }
        else if (happyIndex < 1)
        {
            status = ":(";
        }

        Console.WriteLine($"Happiness index: {happyIndex:F2} {status}");
        Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
    }
}

