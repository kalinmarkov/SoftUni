using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class MatchFullName
{
    static void Main(string[] args)
    {
        var pattren = @"^[A-Z]{1}[a-z]+ [A-Z][a-z]+$";

        var names = Console.ReadLine().Split(',');

        foreach (var name in names)
        {
            Regex reg = new Regex(pattren);

            if (reg.IsMatch(name.Trim()))
            {
                Console.WriteLine(name.Trim());
            }
        }
    }
}

