using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplaceSymbolsInText
{
    static void Main(string[] args)
    {
        var text = "aaaaaaaaa Test Maria test aaaaaaa";

        var result = text.Replace("st", string.Empty).Trim();

        Console.WriteLine(result);
    }
}

