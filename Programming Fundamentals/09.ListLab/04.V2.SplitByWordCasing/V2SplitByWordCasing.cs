using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var separators = new char[]
             { ',', ';', ':', '.', ',', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixedCaseList = new List<string>();

            foreach (var word in words)
            {
                var type = GetWordType(word);
                if (type == WordType.Uppercase)
                {
                    upperCaseList.Add(word);
                }
                else if (type == WordType.Lowercase)
                {
                    lowerCaseList.Add(word);
                }
                else
                {
                    mixedCaseList.Add(word);
                }
            }


            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseList));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseList));
        }

        enum WordType
        {
            Uppercase, MixedCase, Lowercase
        };

        private static WordType GetWordType(string word)
        {
            var lowerLetter = 0;
            var upperLetter = 0;

            foreach (var letter in word)
            {
                if (char.IsUpper(letter))
                {
                    upperLetter++;
                }
                else if (char.IsLower(letter))
                {
                    lowerLetter++;
                }

            }

            if (upperLetter == word.Length)
                return WordType.Uppercase;
            if (lowerLetter == word.Length)
                return WordType.Lowercase;
            return WordType.MixedCase;
        }

    

    }
}

