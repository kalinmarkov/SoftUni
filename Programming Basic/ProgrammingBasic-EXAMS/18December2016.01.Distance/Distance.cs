using System;

class Distance
{
    static void Main()
    {
        int speedKmInHour = int.Parse(Console.ReadLine());
        int firstTimeInMinutes = int.Parse(Console.ReadLine());
        int secondTimeInMinutes = int.Parse(Console.ReadLine());
        int thirdTimeInMinutes = int.Parse(Console.ReadLine());

        float kilometers = speedKmInHour * (firstTimeInMinutes / 60.0f);
        float speed = speedKmInHour * 1.1f;
        kilometers += speed * (secondTimeInMinutes / 60.0f);
        speed -= speed * 0.05f;
        kilometers += speed * (thirdTimeInMinutes / 60.0f);

        Console.WriteLine("{0:f2}", kilometers);
    }
}

