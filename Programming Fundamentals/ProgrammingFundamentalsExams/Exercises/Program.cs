using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //var result = 'b';
        //var letter = result - '0';

        //Console.WriteLine(letter);

        int people = int.Parse(Console.ReadLine());

        var courses = Math.Ceiling((double)people / (4 + 8 + 12));

        Console.WriteLine(courses);
    }
}

