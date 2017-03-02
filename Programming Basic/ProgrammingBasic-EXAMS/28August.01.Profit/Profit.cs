using System;

class Profit
{
    static void Main()
    {
        int workDays = int.Parse(Console.ReadLine());
        double dailyProfit = double.Parse(Console.ReadLine());
        double dollar = double.Parse(Console.ReadLine());

        double yearSalary = (workDays * 12 * dailyProfit) + (dailyProfit * workDays * 2.5);
        double tax = yearSalary * 0.25;
        yearSalary -= tax;
        double SalaryInLevaPerDay = (yearSalary * dollar) / 365;

        Console.WriteLine("{0:f2}", SalaryInLevaPerDay);
        
    }
}

