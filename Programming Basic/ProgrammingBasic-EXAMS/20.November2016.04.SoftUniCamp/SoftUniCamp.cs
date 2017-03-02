using System;

class SoftUniCamp
{
    static void Main()
    {
        int groups = int.Parse(Console.ReadLine());
        int sumOfPeople = 0;
        double peopleWithCars = 0.0;
        double peopleWithMicrobus = 0.0;
        double peopleWithSmallBus = 0.0;
        double peopleWithBigBus = 0.0;
        double peopleWithTrain = 0.0;


        for (int i = 0; i < groups; i++)
        {
            int peopleInGroup = int.Parse(Console.ReadLine());
            sumOfPeople += peopleInGroup;

            if (peopleInGroup <= 5)
            {
                peopleWithCars += peopleInGroup;
            }
            else if (peopleInGroup >5 && peopleInGroup <= 12)
            {
                peopleWithMicrobus += peopleInGroup;
            }
            else if (peopleInGroup > 12 && peopleInGroup <= 25)
            {
                peopleWithSmallBus += peopleInGroup;
            }
            else if (peopleInGroup > 25 && peopleInGroup <= 40)
            {
                peopleWithBigBus += peopleInGroup;
            }
            else if (peopleInGroup > 40)
            {
                peopleWithTrain += peopleInGroup;
            }

        }

        Console.WriteLine("{0:f2}%", peopleWithCars / sumOfPeople * 100);
        Console.WriteLine("{0:f2}%", peopleWithMicrobus / sumOfPeople * 100);
        Console.WriteLine("{0:f2}%", peopleWithSmallBus / sumOfPeople * 100);
        Console.WriteLine("{0:f2}%", peopleWithBigBus / sumOfPeople * 100);
        Console.WriteLine("{0:f2}%", peopleWithTrain / sumOfPeople * 100);
    }
}

