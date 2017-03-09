using System;
using System.Linq;

namespace _09.ReversedChars
{
    class ReversedChars
    {
        static void Main()
        {
            char[] letters = new char[3];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = char.Parse(Console.ReadLine());
            }

            letters = letters.Reverse().ToArray();
            Console.WriteLine(string.Join("", letters));
        }
    }
}
