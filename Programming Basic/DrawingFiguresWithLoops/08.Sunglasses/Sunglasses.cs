using System;

class Sunglasses
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        Console.Write(new string('*', n * 2));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', n * 2));

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < n*2; j++)
            {
                if (j == 0 || j == n*2 - 1)
                {
                Console.Write('*');
                }
                else
                {
                Console.Write('/');
                }
            }
            
            if (i == (n - 1) / 2 - 1)
            {
                Console.Write(new string('|', n));
            }
            else
            {
                Console.Write(new string(' ', n));
            }

            for (int j = n * 2; j <= n * 4 - 1; j++)
            {
                if (j == n * 2 || j == n * 4 - 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('/');
                }
            }
            Console.WriteLine();
        }

        Console.Write(new string('*', n * 2));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', n * 2));
    }
}

