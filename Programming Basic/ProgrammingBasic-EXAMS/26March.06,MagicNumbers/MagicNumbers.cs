using System;

class MagicNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    for (int m = 1; m <= 10; m++)
                    {
                        for (int p = 1; p <= 10; p++)
                        {
                            for (int q = 1; q <= 10; q++)
                            {
                                if (i * j * k * m * p * q == n)
                                {
                                    string result = i.ToString() + j + k + m + p + q;
                                    Console.Write(result + " ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

