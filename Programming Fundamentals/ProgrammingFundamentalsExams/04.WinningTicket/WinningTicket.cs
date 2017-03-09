using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class WinningTicket
{
    static void Main()
    {
        var tickets = Console.ReadLine()
               .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(t => t.Trim())
               .ToArray();

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            var leftSide = new string(ticket.Take(10).ToArray());
            var rightSide = new string(ticket.Skip(10).ToArray());

            string[] winningSymbols = new string[]{ "\\$", "@", "\\^", "#" };
            var winningTicket = false;

            foreach (var winningSymbol in winningSymbols)
            {
                var regex = new Regex($"{winningSymbol}{{6,}}");
                var leftMatch = regex.Match(leftSide);
                if (leftMatch.Success)
                {
                    var rightMatch = regex.Match(rightSide);
                    if (rightMatch.Success)
                    {
                        winningTicket = true;

                        var leftSymbolsLenght = leftMatch.Value.Length;
                        var rightSymbolsLengt = rightMatch.Value.Length;
                        var jackpot = leftSymbolsLenght == 10 && rightSymbolsLengt == 10
                            ? " Jackpot!"
                            : string.Empty;

                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftSymbolsLenght, rightSymbolsLengt)}{winningSymbol.Trim('\\')}{jackpot}");
                        break;
                    }
                }
            }

            if (!winningTicket)
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
        
    }
}

