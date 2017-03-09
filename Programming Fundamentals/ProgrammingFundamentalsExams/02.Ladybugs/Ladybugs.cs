using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var fieldSize = int.Parse(Console.ReadLine());
        var ladybugPosition = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(a => a >= 0 && a < fieldSize)
            .ToArray();
        var arrOfLadybugs = new int[fieldSize];

        for (int i = 0; i < ladybugPosition.Length; i++)
        {
            var currentLadybugIndex = ladybugPosition[i];
            arrOfLadybugs[currentLadybugIndex] = 1;
        }

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            var tokens = input.Split().ToArray();
            var ladybugIndex = int.Parse(tokens[0]);
            var direction = tokens[1];
            var step = int.Parse(tokens[2]);

            if (ladybugIndex < 0 || ladybugIndex >= arrOfLadybugs.Length)
            {
                continue;
            }

            if (arrOfLadybugs[ladybugIndex] == 0)
            {
                continue;
            }

            MoveLadybugs(arrOfLadybugs, ladybugIndex, step, direction);
        }

        Console.WriteLine(string.Join(" ", arrOfLadybugs));
    }

    private static void MoveLadybugs(int[] arrOfLadybugs, int ladybugIndex, int step, string direction)
    {
        arrOfLadybugs[ladybugIndex] = 0;

        var leftArrayOrFoundPlace = false;
        while (!leftArrayOrFoundPlace)
        {
            switch (direction)
            {
                case "left":
                    ladybugIndex -= step;
                    break;
                case "right":
                    ladybugIndex += step;
                    break;
            }

            if (ladybugIndex < 0 || ladybugIndex >= arrOfLadybugs.Length)
            {
                leftArrayOrFoundPlace = true;   // left array
                continue;
            }

            if (arrOfLadybugs[ladybugIndex] == 1)
            {
                continue;   // stepping over another ladybug, keep flying
            }

            if (arrOfLadybugs[ladybugIndex] == 0)
            {
                arrOfLadybugs[ladybugIndex] = 1;
                leftArrayOrFoundPlace = true;   // found our place in the array
                continue;
            }
        }
    }
}

