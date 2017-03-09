using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random rand = new Random();

            for (int currentWord = 0; currentWord < words.Count; currentWord++)
            {
                int secondWordIndex = rand.Next(0, words.Count);
                string oldWord = words[currentWord];

                words[currentWord] = words[secondWordIndex];
                words[secondWordIndex] = oldWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
