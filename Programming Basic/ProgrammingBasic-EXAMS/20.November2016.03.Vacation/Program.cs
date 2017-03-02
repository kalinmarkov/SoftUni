using System;

class Program
{
    static void Main()
    {
        int oldPeople = int.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine();
        double priceForTickets = 0.0;
        double hotel = nights * 82.99;

        if (transport == "train")
        {
            if (oldPeople + students > 50)
            {
                priceForTickets = ((oldPeople * 24.99) + (students * 14.99)) * 0.5;
            }
            else
            {
                priceForTickets = (oldPeople * 24.99) + (students * 14.99);
            }
        }
        else if (transport == "bus")
        {
            priceForTickets = (oldPeople * 32.50) + (students * 28.50);
        }
        else if (transport == "boat")
        {
            priceForTickets = (oldPeople * 42.99) + (students * 39.99);
        }
        else if (transport == "airplane")
        {
            priceForTickets = (oldPeople  * 70.00) + (students  * 50.00);
        }

        double commission = (hotel + priceForTickets * 2) * 1.10;

        Console.WriteLine("{0:f2}", commission);
    }
}

