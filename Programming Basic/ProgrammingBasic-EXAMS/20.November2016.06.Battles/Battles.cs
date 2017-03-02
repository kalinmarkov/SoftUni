using System;

class Battles
{
    static void Main()
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());
        int maxFights = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i <= firstPlayer; i++)
        {
            for (int j = 1; j <= secondPlayer; j++)
            {
                counter++;
                if (counter <= maxFights)
                {
                    Console.Write($"({i} <-> {j}) ");
                }
                else
                {
                    break;
                }
            }
        }
    }
}

