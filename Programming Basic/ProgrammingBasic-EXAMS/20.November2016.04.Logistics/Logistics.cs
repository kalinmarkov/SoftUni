using System;

class Logistics
{
    static void Main()
    {
        int load = int.Parse(Console.ReadLine());
        int microbus = 200;
        int truck = 175;
        int train = 120;
        double sum = 0.0;
        double counter = 0.0;
        double microbusCounter = 0.0;
        double truckCounter = 0.0;
        double trainCounter = 0.0;
        for (int i = 0; i < load; i++)
        {
            int tonnage = int.Parse(Console.ReadLine());
            counter += tonnage;

            if (tonnage <= 3)
            {
                sum += microbus * tonnage;
                microbusCounter += tonnage;
            }
            if (tonnage >= 4 && tonnage <= 11)
            {
                sum += truck * tonnage;
                truckCounter += tonnage;
            }
            if (tonnage >= 12)
            {
                sum += train * tonnage;
                trainCounter += tonnage;
            }
        }

        Console.WriteLine("{0:f2}", sum = sum / counter);
        Console.WriteLine("{0:f2}%", microbusCounter / counter * 100);
        Console.WriteLine("{0:f2}%", truckCounter / counter * 100);
        Console.WriteLine("{0:f2}%", trainCounter / counter * 100);

    }
}

