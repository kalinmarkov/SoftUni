using System;

class MaxCombination
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int maxCombinations = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = first; i <= second; i++)
        {
            for (int j = first; j <= second; j++)
            {
                counter++;
                if (counter <= maxCombinations)
                {
                    Console.Write("<{0}-{1}>", i, j);
                }
                else
                {
                    break;
                }
            }
        }
    }
}

