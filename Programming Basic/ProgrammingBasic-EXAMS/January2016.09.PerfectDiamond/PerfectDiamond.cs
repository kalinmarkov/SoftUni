using System;

class PerfectDiamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outside = n - 1;
        int starsDashes = 1;
        

        Console.WriteLine("{0}*{0}", new string(' ', outside));
        for (int i = 1; i < n; i++)
        {
            outside--;
            Console.Write("{0}", new string(' ', outside));
            for (int j = 0; j < i; j++)
            {
                Console.Write("*-");
            }
            Console.WriteLine("*");
        }

        for (int i = n-1; i > 0; i--)
        {
            outside++;
            Console.Write("{0}", new string(' ', outside));
            for (int j = i - 1; j > 0; j--)
            {
                Console.Write("*-");
            }
            Console.WriteLine("*");
        }
    }
}

