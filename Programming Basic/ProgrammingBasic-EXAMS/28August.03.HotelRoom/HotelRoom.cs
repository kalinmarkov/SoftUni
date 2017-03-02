using System;

class HotelRoom
{
    static void Main()
    {
        string month = Console.ReadLine();
        int night = int.Parse(Console.ReadLine());
        double studio = 0;
        double apartment = 0;
     
        if (month == "May" || month == "October")
        {
            studio = 50;
            apartment = 65;
            if (night > 7 && night <= 14)
            {
                studio -= (studio * 0.05);              
            }
            else if (night > 14)
            {
                studio -= (studio * 0.30);
                apartment -= (apartment * 0.10);
            }

            Console.WriteLine("Apartment: {0:f2} lv.", (apartment * night));
            Console.WriteLine("Studio: {0:f2} lv.", (studio * night));
        }
        else if (month == "June" || month == "September")
        {
            studio = 75.20;
            apartment = 68.70;
            if (night > 14)
            {
                studio -= (studio * 0.20);
                apartment -= (apartment * 0.10);
            }

            Console.WriteLine("Apartment: {0:f2} lv.", (apartment * night));
            Console.WriteLine("Studio: {0:f2} lv.", (studio * night));
        }
        else
        {
            studio = 76;
            apartment = 77;
            if (night > 14)
            {
                apartment -= (apartment * 0.10);
            }

            Console.WriteLine("Apartment: {0:f2} lv.", (apartment * night));
            Console.WriteLine("Studio: {0:f2} lv.", (studio * night));
        }

    }
}
