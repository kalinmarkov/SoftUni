using System;
using System.Linq;

class Placeholders
{
    static void Main()
    {

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            var tokens = input
                .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var sentance = tokens[0];
            var elements = tokens[1]
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();           

            for (int i = 0; i < elements.Length; i++)
            {
                var currentPlaceholder = "{" + i + "}";

                sentance = sentance.Replace(currentPlaceholder, elements[i]);
            }

            Console.WriteLine(sentance);
            
        }
    }
}

