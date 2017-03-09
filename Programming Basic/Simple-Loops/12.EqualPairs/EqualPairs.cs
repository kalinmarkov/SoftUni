using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        int sum4 = 0;
        int max1 = 0;
        int max2 = 0;
        int max3 = 0;
        int min1 = 0;
        int min2 = 0;
        int min3 = 0;


        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                sum1 += (num + num1);
                if (num == num1)
                {
                    // Console.WriteLine("yes value {O}", sum1);
                }
                else
                {
                    // Console.WriteLine("no maxdiff " + (Math.Max(num, num1) - Math.Min(num, num1)));
                }
            }

            if (i == 1)
            {
                sum2 += (num + num1);

                if ((sum1 == sum2) && (i == n - 1))
                {
                    Console.WriteLine("yes value {0}", sum1);
                }
                else
                {
                    max1 = Math.Max(sum1, sum2);
                    min1 = Math.Min(sum1, sum2);
                    Console.WriteLine("no maxdiff " + (max1 - min1));
                }

            }

            if (i == 2)
            {
                sum3 += (num + num1);

                if ((sum1 == sum2 && sum1 == sum3) && (i == n - 1))
                {
                    Console.WriteLine("yes value {0}", sum1);
                }
                else
                {
                    max2 = Math.Max(max1, sum3);
                    min2 = Math.Min(min1, sum3);

                    Console.WriteLine("no maxdiff = " + (max2 - min2));
                }

            }

            if (i == 3)
            {
                sum4 += (num + num1);

                if ((sum1 == sum2 && sum1 == sum3 && sum1 == sum4) && (i == n - 1))
                {
                    Console.WriteLine("yes value {0}", sum1);
                }
                else
                {
                    max3 = Math.Max(max2, sum4);
                    min3 = Math.Min(min2, sum4);

                    Console.WriteLine("no maxdiff " + (max3 - min3));
                }

            }

        }

        //Console.WriteLine(sum1);
        //Console.WriteLine(sum2);
        //Console.WriteLine(sum3);
        //Console.WriteLine(sum4);
    }
}

