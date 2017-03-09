using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ASCIIString
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = string.Empty;

        for (int i = 0; i < n; i++)
        {
            int asciiCode = int.Parse(Console.ReadLine());
            char character = (char)asciiCode;
            result += character;
        }

        Console.WriteLine(result);
    }
}

