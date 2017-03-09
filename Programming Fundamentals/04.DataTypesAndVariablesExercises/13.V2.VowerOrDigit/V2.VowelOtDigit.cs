using System;

namespace _13.V2.VowerOrDigit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            if (n == 'a' || n == 'e' || n == 'o' || n == 'u' || n == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(n))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
