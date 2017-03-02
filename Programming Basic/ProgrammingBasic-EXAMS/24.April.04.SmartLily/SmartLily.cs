using System;

class Program
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double laundryPrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());
        int birthdayGift = 0;
        int birthdayMoney = 0;
        double totalMoney = 0.0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 != 0 )
            {
                birthdayGift++;
            }
            else
            {
                
                birthdayMoney += ((i * 5) - 1); 
                
            }
            
        }

        totalMoney += (birthdayGift * toyPrice) + birthdayMoney;
        if (laundryPrice <= totalMoney)
        {
            Console.WriteLine("Yes! {0:f2}", Math.Abs(totalMoney - laundryPrice));
        }
        else
        {
            Console.WriteLine("No! {0:f2}", Math.Abs(totalMoney - laundryPrice));

        }
    }
}

