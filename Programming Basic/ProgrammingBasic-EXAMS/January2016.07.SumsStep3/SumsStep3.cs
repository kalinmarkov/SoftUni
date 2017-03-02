using System;

    class SumsStep3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int count1 = 1;
            int count2 = 2;
            int count3 = 3;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == count1)
                {
                    sum1 += num;
                    count1 += 3;
                }
                else if (i == count2)
                {
                    sum2 += num;
                    count2 += 3;
                }
                else if (i == count3)
                {
                    sum3 += num;
                    count3 += 3;
                }

            }

            Console.WriteLine("sum1 " + sum1);
            Console.WriteLine("sum2 " + sum2);
            Console.WriteLine("sum3 " + sum3);
        }
    }

