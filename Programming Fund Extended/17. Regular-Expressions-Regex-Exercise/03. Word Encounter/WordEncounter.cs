using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class WordEncounter
{
    static void Main()
    {
        var filter = Console.ReadLine();
        var validWords = new List<string>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            //Check for sentance match.
            var isMatch = Regex.IsMatch(input, @"(?<!.)[A-Z](.*)[.!?](?!.)"); //negative lookbehind and negative lookahead.

            if (isMatch)
            {
                //Take each word from sentance.
                var words = Regex.Matches(input, @"(\w+)");

                foreach (Match word in words)
                {
                    var letter = filter[0];
                    var minLenght = int.Parse(filter[1].ToString());
                    var currentWord = word.Groups[0].Value;
                    var counter = 0;
                    for (int i = 0; i < currentWord.Length; i++)
                    {
                        if (currentWord[i] == letter)
                        {
                            counter++;
                        }
                    }

                    if (counter >= minLenght)
                    {
                        validWords.Add(currentWord);
                    }

                    counter = 0;
                }
            }
            
        }

        Console.WriteLine(string.Join(", ", validWords));
    }
}

