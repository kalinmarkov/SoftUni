using System;

namespace _13.VowelOrDigit
{
    public class VowelOrDigit
    {
        public static void Main(string[] args)
        {
            string symbol = Console.ReadLine().ToLower();

            int value;

            if (int.TryParse(symbol, out value))
            {
                Console.WriteLine("digit");
            }
            else if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u" || symbol == "y")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
