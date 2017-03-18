using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddOccurrences
{
    static void Main()
    {
        var input = Console.ReadLine().ToLower().Split().ToArray();
        var words = new Dictionary<string, int>();

        foreach (var word in input)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, 1);
            }
            else
            {
                words[word]++;
            }
        }

        var result = new List<string>();

        foreach (var word in words.Where(x => x.Value % 2 != 0))
        {
            result.Add(word.Key);
        }

        Console.WriteLine(string.Join(", ", result));
    }
}

