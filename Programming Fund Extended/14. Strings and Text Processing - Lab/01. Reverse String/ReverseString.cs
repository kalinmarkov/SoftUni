using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        var inputString = Console.ReadLine();
        var reversedString = string.Join("", inputString.ToCharArray().Reverse());
        Console.WriteLine(reversedString);
    }
}

