using System;

class IncreasingElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int maxCounter = n > 0 ? 1 : 0;
        int previousNum = 0; ;
        if (n > 0)
        {
            previousNum = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            if (currentNum > previousNum)
            {
                counter++;
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                }
            }
            else
            {
                counter = 1;
            }

            previousNum = currentNum;
        }

        Console.WriteLine(maxCounter);

    }
}

