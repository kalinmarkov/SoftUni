using System;

class Firm
{
    static void Main()
    {
        int neededHours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double workHours = (days - days * 0.10) * 8;
        double overtime = workers * days * 2;
        double totalHours = Math.Truncate(workHours + overtime);

        if (neededHours <= totalHours)
        {
            Console.WriteLine("Yes!{0} hours left.", Math.Round(totalHours - neededHours));
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", Math.Round(neededHours - totalHours));
        }
    }
}

