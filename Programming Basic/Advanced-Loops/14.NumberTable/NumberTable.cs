using System;

class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int increase = i;
            int decrease = n;
            for (int j = 1; j <= n; j++)
            {
                if (increase < n)
                {
                    Console.Write(increase + " ");
                    increase++;
                }
                else
                {
                    Console.Write(decrease + " ");
                    decrease--;
                }
            }

            Console.WriteLine();
        }
    }
}
