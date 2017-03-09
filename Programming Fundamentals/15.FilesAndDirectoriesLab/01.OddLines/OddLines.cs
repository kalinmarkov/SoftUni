using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            var file = "input.txt";

            var lines = File.ReadAllLines(file);
            
            var oddLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(lines[i]);
                }
            }

            File.WriteAllLines("result.txt", oddLines);
        }
    }
}
