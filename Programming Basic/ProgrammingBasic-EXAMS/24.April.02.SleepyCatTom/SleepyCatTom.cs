using System;

class SleepyCatTom
{
    static void Main()
    {
        int holliday = int.Parse(Console.ReadLine());
        int days = 365 - holliday;
        double minForPlaying = (days * 63 + holliday * 127);
        double hours = Math.Abs((minForPlaying - 30000) / 60);
        double mins = Math.Abs((minForPlaying - 30000) % 60);
        if (minForPlaying > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", Math.Truncate(hours), mins);
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", Math.Truncate(hours), mins);
        }

    }
}

