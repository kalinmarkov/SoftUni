using System;
using System.Collections.Generic;

class RecordUniqueNames
{
    static void Main()
    {
        var names = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            names.Add(input);
        }

        Console.WriteLine(string.Join(Environment.NewLine, names));
    }
}

