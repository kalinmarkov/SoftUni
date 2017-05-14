using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class WormIpsum
{
    static void Main()
    {
        var sentenceReg = new Regex(@"^[A-Z][^\.]*\.$");
        var wordsReg = new Regex(@"[^\s,\.]+");

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "Worm Ipsum")
            {
                break;
            }

            var sentenceMatch = sentenceReg.Match(input);

            if (sentenceMatch.Success)
            {
                var wordsMatches = wordsReg.Matches(input);
                foreach (Match match in wordsMatches)
                {
                    var currentWord = match.Value;
                    if (currentWord.Length != currentWord.Distinct().Count())
                    {
                        var symbol = currentWord.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                        var newWord = string.Concat(Enumerable.Repeat(symbol, currentWord.Length));
                        input = Regex.Replace(input, currentWord, newWord);

                    }
                }

                Console.WriteLine(input);
            }
            
        }
    }
    
}

