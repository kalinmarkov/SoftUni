using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringEncryption
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var result = string.Empty;

        for (int i = 0; i < n; i++)
        {
            char currentChar = char.Parse(Console.ReadLine());
            var encripted = Encript(currentChar);
            
            result += encripted;
        }

        Console.WriteLine(result);
    }

    static string Encript(char currentChar)
    {
        var asciiCode = (int)currentChar;

        var firstDigit = GetFirstDigit(asciiCode);
        var lastDigit = GetLastDigit(asciiCode);

        var firstSymbol = (char)(asciiCode + lastDigit);
        var lastSymbol = (char)(asciiCode - firstDigit);

        var result = $"{firstSymbol}{firstDigit}{lastDigit}{lastSymbol}";

        return result;
    }

    private static int GetLastDigit(int asciiCode)
    {
        var lastDigit = asciiCode % 10;
        return lastDigit;
    }

    private static int GetFirstDigit(int asciiCode)
    {
        var firstDigit = asciiCode;

        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }

        return firstDigit;
    }
}

