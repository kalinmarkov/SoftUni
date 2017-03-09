using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    char firstLetter = (char)('a' + i);
                    char secondLetter = (char)('a' + j);
                    char thirdLetter = (char)('a' + k);

                    Console.WriteLine("{0}{1}{2}", firstLetter, secondLetter, thirdLetter);
                }
            }
        }
    }
}

