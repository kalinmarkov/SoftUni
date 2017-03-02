using System;

class Hospital
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int treated = 0;
        int untreated = 0;
        int doctors = 7;

        for (int i = 1; i <= days; i++)
        {
            int patient = int.Parse(Console.ReadLine());
            if (i % 3 == 0 && untreated > treated) 
            {
                doctors++;
            }

            if (patient <= 7)
            {
                treated += patient;
            }

            if (patient > 7)
            {
                treated += doctors;
                untreated += (patient - doctors);
            }
        }

        Console.WriteLine("Treated patients: {0}.", treated);
        Console.WriteLine("Untreated patients: {0}.", untreated);

    }
}

