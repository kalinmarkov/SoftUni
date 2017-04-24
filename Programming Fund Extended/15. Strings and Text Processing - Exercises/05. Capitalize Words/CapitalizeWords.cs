using System;
using System.Collections.Generic;
using System.Linq;

class CapitalizeWords
{
    static void Main()
    {

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var words = input.Split(".?!, -:;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var allWords = new List<string>();

            foreach (var word in words)
            {
                var currentWord = word.Substring(0, 1).ToUpper() + (new string(word.Skip(1).ToArray())).ToLower();

                allWords.Add(currentWord);
            }

            Console.WriteLine(string.Join(", ", allWords));
        }
    }
}

