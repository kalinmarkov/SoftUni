using System;
using System.Collections.Generic;
using System.Linq;

class CommandInterpreter
{
    static void Main()
    {
        var collection = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split();

            var command = tokens[0];
            switch (command)
            {
                case "reverse":
                    var reverseStart = int.Parse(tokens[2]);
                    var reverseCount = int.Parse(tokens[4]);

                    if (IsValid(collection,reverseStart ,reverseCount))
                    {
                        Reverse(collection , reverseStart, reverseCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    break;
                case "sort":
                    var sortStart = int.Parse(tokens[2]);
                    var sortCount = int.Parse(tokens[4]);

                    if (IsValid(collection, sortStart, sortCount))
                    {
                        Sort(collection, sortStart, sortCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    break;
                case "rollLeft":
                    var rollLeftCount = int.Parse(tokens[1]);

                    if (rollLeftCount >= 0)
                    {
                        RollLeft(collection, rollLeftCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    break;
                case "rollRight":
                    var rollRightCount = int.Parse(tokens[1]);

                    if (rollRightCount >= 0)
                    {
                        RollRight(collection, rollRightCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", collection)}]");
    }

    private static void Reverse(List<string> collection, int reverseStart, int reverseCount)
    {
        collection.Reverse(reverseStart, reverseCount);
    }

    private static void Sort(List<string> collection, int sortStart, int sortCount)
    {
        collection.Sort(sortStart, sortCount, null);
    }


    private static void RollLeft(List<string> collection, int rollLeftCount)
    {
        var rotation = rollLeftCount % collection.Count;

        for (int i = 0; i < rotation; i++)
        {
            var firstElement = collection[0];
            for (int j = 0; j < collection.Count - 1; j++)
            {
                collection[j] = collection[j + 1];

                //1 = firstElement
                //1 2 3 4
                //...
                //2 3 4 4
            }

            collection[collection.Count - 1] = firstElement;
        }
    }

    private static void RollRight(List<string> collection, int rollRightCount)
    {
        var rotation = rollRightCount % collection.Count;

        for (int i = 0; i < rotation; i++)
        {
            var lastElement = collection[collection.Count - 1];

            for (int j = collection.Count - 1; j > 0; j--)
            {
                collection[j] = collection[j - 1];
            }

            collection[0] = lastElement;
        }
    }

    private static bool IsValid(List<string> collection, int start, int count)
    {
        bool result = start >= 0 && 
            start < collection.Count &&
            count >= 0 && 
            (start + count) <= collection.Count;

        return result;
    }
}

