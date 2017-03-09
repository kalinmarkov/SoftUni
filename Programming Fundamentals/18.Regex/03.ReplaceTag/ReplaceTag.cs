using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"(.*)<a\s*(.+.\w+.)>(.+)<\/a>(.*)";

        string input = Console.ReadLine();
        while (!input.Equals("end"))
        {
            Console.WriteLine(new Regex(pattern).Replace(input, @"$1[URL $2]$3[/URL]$4"));

            input = Console.ReadLine();
        }
    }
}

