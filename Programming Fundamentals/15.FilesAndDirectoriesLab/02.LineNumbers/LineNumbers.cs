using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            var file = "input.txt";

            var lines = File.ReadAllLines(file);

            var linesWithNumbers = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                linesWithNumbers.Add($"{i + 1}. {lines[i]}");
            }

            File.WriteAllLines("result.txt", linesWithNumbers);
        }
    }
}
