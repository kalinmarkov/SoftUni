using System;
using System.Linq;

namespace _06.ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            var reversedArray = array.Reverse();

            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}
