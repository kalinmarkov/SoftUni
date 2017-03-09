using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.V3.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());

            switch (n)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    if (char.IsNumber(n))
                    {
                        Console.WriteLine("Digit");
                    }
                    else
                    {
                        Console.WriteLine("other");
                    }
                    break;
            }
        }
    }
}
