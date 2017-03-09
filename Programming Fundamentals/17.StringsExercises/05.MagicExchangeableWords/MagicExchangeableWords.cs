using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] strings = Console.ReadLine().Split();

            int first = CountUniqueCharacters(strings[0]);
            int second = CountUniqueCharacters(strings[1]);

            if (first == second)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static int CountUniqueCharacters(string s)
        {
            List<char> chars = s.ToCharArray()
                .Distinct()
                .ToList();

            return chars.Count;
        }
    }
}
