using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WormIpsum
{
    static void Main()
    {
        while (true)
        {
            var inputText = Console.ReadLine();
            if (inputText == "Worm Ipsum")
            {
                break;
            }

            if (!inputText.EndsWith("."))
            {
                continue;
            }

            inputText = inputText.Trim('.');

            if (inputText.Contains("."))
            {
                continue;
            }

            var tokens = inputText.Split().ToList();

            var firstWord = tokens.First();

            if (!StartsWithUpper(firstWord))
            {
                continue;
            }


            for (int i = 0; i < tokens.Count; i++)
            {
                var hasRepeatedChar = false;
                var repeatedChar = '\0';
                var word = tokens[i];
                for (int j = 0; j < word.Length; j++)
                {
                    var count = 0;
                    var currentChar = word[j];
                    for (int k = 0; k < word.Length; k++)
                    {
                        var checkedChar = word[k];
                        if (checkedChar == currentChar)
                        {
                            count++;
                            if (count > 1)
                            {
                                repeatedChar = currentChar;
                                hasRepeatedChar = true;
                            }
                        }
                    }
                }

                if (hasRepeatedChar)
                {
                    tokens[i] = word.Replace(word, new string(repeatedChar, word.Length));
                }

            }

            Console.WriteLine($"{string.Join(" ", tokens)}.");
        }
    }
    public static bool StartsWithUpper(string word)
    {
        return Enumerable.Range(65, 26).Contains((int)word[0]);
    }
}

