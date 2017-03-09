using System;

class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;

        for (int i = 2; i <= n + 1; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (j > 0)
                {
                    Console.Write(num);
                    Console.Write(" ");
                    num++;
                }

                if (num > n)
                {
                    break;
                }
            }

            Console.WriteLine();
            if (num > n)
            {
                break;
            }
        }
    }
}

