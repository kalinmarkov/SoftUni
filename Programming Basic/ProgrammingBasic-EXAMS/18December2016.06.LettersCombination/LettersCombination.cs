using System;

class LettersCombination
{
    static void Main()
    {
        char begin = char.Parse(Console.ReadLine());
        char end = char.Parse(Console.ReadLine());
        char missingChar = char.Parse(Console.ReadLine());
        int counter = 0;

        for (char i = begin; i <= end; i++)
        {
            for (char j = begin; j <= end; j++)
            {
                for (char k = begin; k <= end; k++)
                {
                    string result = i.ToString() + j + k + " ";
                    if (i == missingChar || j == missingChar || k == missingChar)
                    {
                        Console.Write("");
                    }
                    else
                    {
                        counter++;
                        Console.Write(result);
                    }

                }

            }

        }

        Console.WriteLine(counter);
    }
}

