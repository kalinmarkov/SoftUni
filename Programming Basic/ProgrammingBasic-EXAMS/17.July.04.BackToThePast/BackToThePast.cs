using System;

class BackToThePast
{
    static void Main()
    {
        double heritage = double.Parse(Console.ReadLine());
        int yearToSurvive = int.Parse(Console.ReadLine());
        double leftMoney = heritage;
        int age = 18;

        for (int i = 1800; i <= yearToSurvive; i++)
        {

            if (i % 2 == 0)
            {
                leftMoney = leftMoney - 12000;
            }
            else
            {
                leftMoney = leftMoney - 12000 - age * 50;
            }

            age++;
        }

        if (0 <= leftMoney && leftMoney <= heritage)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", (leftMoney));
        }
        else
        {
            Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(leftMoney));
        }

    }
}

