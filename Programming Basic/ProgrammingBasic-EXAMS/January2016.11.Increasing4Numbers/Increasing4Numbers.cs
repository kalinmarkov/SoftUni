using System;

class Increasing4Numbers
{
    static void Main()
    {
                                                              //  a ≤ n1 < n2 < n3 < n4 ≤ b
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (b - a < 4)
        {
            Console.WriteLine("no");
        }
        for (int i = a; i <= b; i++)
        {
            for (int j = a; j <= b; j++)
            {
                for (int k = a; k <= b; k++)
                {
                    for (int m = a; m <= b; m++)
                    {
                        if (a <= i && i < j && j < k && k < m && m <= b)
                        {
                            Console.WriteLine($"{i} {j} {k} {m}");
                        }
                    }
                }
            }
        }
    }
}

