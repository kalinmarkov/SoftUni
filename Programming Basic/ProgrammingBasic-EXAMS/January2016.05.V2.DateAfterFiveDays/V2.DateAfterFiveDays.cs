using System;

class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());

        var year = DateTime.Now.Year;

        var dateNow = new DateTime(year, month, day);
        var dateInFiveDays = dateNow.AddDays(5);

        Console.WriteLine("{0}.{1}", dateInFiveDays.Day, dateInFiveDays.Month);
    }
}

