using System;
using System.Text.RegularExpressions;

class FishStatistics
{
    static void Main()
    {
        var inputFishType = Console.ReadLine();

        var pattern = "([>]*)<([(]+)('|-|x)>";

        var regex = new Regex(pattern);

        var fishMatches = regex.Matches(inputFishType);

        if (fishMatches.Count == 0)
        {
            Console.WriteLine("No fish found.");
        }
        else
        {
            var counter = 1;
            foreach (Match fish in fishMatches)
            {
            
                Console.WriteLine($"Fish {counter}: {fish.Groups[0].Value}");

                var tailLengh = fish.Groups[1].Length;
                if (tailLengh == 0)
                {
                    Console.WriteLine("  Tail type: None");
                }
                if (tailLengh == 1)
                {
                    Console.WriteLine($"  Tail type: Short ({tailLengh * 2} cm)");
                }
                if (tailLengh > 1 && tailLengh <= 5)
                {
                    Console.WriteLine($"  Tail type: Medium ({tailLengh * 2} cm)");
                }
                if(tailLengh > 5)
                {
                    Console.WriteLine($"  Tail type: Long ({tailLengh * 2} cm)");
                }

                var bodyLengh = fish.Groups[2].Length;
                if (bodyLengh <= 5)
                {
                    Console.WriteLine($"  Body type: Short ({bodyLengh * 2} cm)");
                }
                if (bodyLengh > 5 && bodyLengh <= 10)
                {
                    Console.WriteLine($"  Body type: Medium ({bodyLengh * 2} cm)");
                }
                if (bodyLengh > 10)
                {
                    Console.WriteLine($"  Body type: Long ({bodyLengh * 2} cm)");
                }

                var status = fish.Groups[3].Value;
                if (status == "'")
                {
                    status = "Awake";
                    Console.WriteLine($"  Status: {status}");
                }
                if (status == "-")
                {
                    status = "Asleep";
                    Console.WriteLine($"  Status: {status}");
                }
                if (status == "x")
                {
                    status = "Dead";
                    Console.WriteLine($"  Status: {status}");
                }

                counter++;
            }
        }
    }
}

