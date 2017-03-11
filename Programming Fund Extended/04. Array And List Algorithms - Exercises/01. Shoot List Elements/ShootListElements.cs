using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int>();

        var lastRemovedInt = 0;

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "stop")
            {
                if (numbers.Count > 0)
                {
                    Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
                }
                else if (numbers.Count == 0)
                {
                    Console.WriteLine($"you shot them all. last one was {lastRemovedInt}");
                }
                break;
            }

            if (input.All(char.IsDigit))
            {
                numbers.Insert(0, int.Parse(input));
            }

            if (input == "bang")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastRemovedInt}");
                    break;
                }

                var average = numbers.Average();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= average)
                    {
                        lastRemovedInt = numbers[i];
                        numbers.RemoveAt(i);
                        Console.WriteLine("shot {0}", lastRemovedInt);
                        break;
                    }
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]--;
                }

                
            }
            
        }
    }
}


