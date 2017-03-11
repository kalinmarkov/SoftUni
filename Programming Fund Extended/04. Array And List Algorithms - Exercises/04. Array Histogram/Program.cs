using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var text = Console.ReadLine().Split().ToArray();

        var words = new List<string>();
        var wordsCount = new List<int>();
        var wordIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (!words.Contains(text[i]))
            {
                words.Add(text[i]);
                wordsCount.Add(1);
            }
            else
            {
                wordIndex = words.IndexOf(text[i]);
                wordsCount[wordIndex]++;
            }

        }

        var swapped = true;
        while (swapped)
        {
            swapped = false;
                
            for (int i = 0; i < wordsCount.Count - 1; i++)
            {
                if (wordsCount[i] < wordsCount[i + 1])
                {
                    var temp = wordsCount[i];
                    wordsCount[i] = wordsCount[i + 1];
                    wordsCount[i + 1] = temp;

                    var tempWord = words[i];
                    words[i] = words[i + 1];
                    words[i + 1] = tempWord;

                    swapped = true;
                }

            }

        }

        for (int i = 0; i < words.Count; i++)
        {
            double percentage = wordsCount[i] * 100.0 / text.Length;
            Console.WriteLine($"{words[i]} -> {wordsCount[i]} times ({percentage:F2}%)");
        }
    }
}