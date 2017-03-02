using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int inDots = 3 * n;
        int outDots = n - 1;
        int stars = 1;


        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

        for (int i = 0; i < n; i++)
        {

            if (i < n - 1)
            {
                Console.Write("{0}*{1}*{0}", new string('.', outDots), new string('.', inDots));
                outDots--;
                inDots += 2;                
            }
            else
            {
                break;
            }
            Console.WriteLine();
        
        }

        Console.WriteLine(new string('*', n * 5));

        for (int i = 0; i < (2 * n) + 2; i++)
        {
            if (i < (2 * n) + 2 - 2)
            {
                outDots++;
                inDots -= 2;
                Console.Write("{0}*{1}*{0}", new string('.', outDots), new string('.', inDots));
            }
            if (i == (2 * n) + 2 - 2 )
            {
                break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));
    }
}
