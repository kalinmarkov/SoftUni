using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CommandInterpreter
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        while (true)
        {
            string[] command = Console.ReadLine().Split().ToArray();

            if (command[0] == "end")
            {
                break;
            }

            switch (command[0])
            {
                case "reverse":
                    Reverse(input, command);
                    break;
                case "sort":
                    Sort(input, command);
                    break;
                case "rollLeft":
                    RollLeft(input, command);
                    break;
                case "rollRight":
                    RollRight(input, command);
                    break;
                default:
                    break;
            }
        }

        string output = string.Join(", ", input);
        Console.WriteLine($"[{output}]");

    }

    private static void RollRight(List<string> input, string[] command)
    {
        int count = int.Parse(command[1]);

        if (count < 0)
        {
            PrintInvalidMessage();
            return;
        }

        for (int i = 0; i < count % input.Count; i++)
        {
            string temp = input[input.Count - 1];
            input.RemoveAt(input.Count - 1);
            input.Insert(0, temp);
        }
    }

    private static void RollLeft(List<string> input, string[] command)
    {
        int count = int.Parse(command[1]);

        if (count < 0)
        {
            PrintInvalidMessage();
            return;
        }

        for (int i = 0; i < count % input.Count; i++)
        {
            string temp = input[0];
            input.RemoveAt(0);
            input.Add(temp);
        }
    }

    private static void Sort(List<string> input, string[] command)
    {
        int start = int.Parse(command[2]);
        int count = int.Parse(command[4]);

        if (start < 0
                            || count < 0
                            || start >= input.Count
                            || (start + count) > input.Count)
        {
            PrintInvalidMessage();
            return;
        }
        else
        {
            List<string> currList = input
                                    .Skip(start)
                                    .Take(count)
                                    .OrderBy(str => str)
                                    .ToList();

            input.RemoveRange(start, count);
            input.InsertRange(start, currList);
        }

    }

    private static void Reverse(List<string> input, string[] command)
    {
        int start = int.Parse(command[2]);
        int count = int.Parse(command[4]);

        if (start < 0
                            || count < 0
                            || start >= input.Count
                            || (start + count) > input.Count)
        {
            PrintInvalidMessage();
            return;
        }
        else
        {
            List<string> currList = input
                                    .Skip(start)
                                    .Take(count)
                                    .Reverse()
                                    .ToList();

            input.RemoveRange(start, count);
            input.InsertRange(start, currList);
        }

    }

    public static void PrintInvalidMessage()
    {
        Console.WriteLine("Invalid input parameters.");
    }
}

