using System;

class Program
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        int capacityOfElevator = int.Parse(Console.ReadLine());

        int courses = (int)Math.Ceiling((double)people / capacityOfElevator);

        Console.WriteLine(courses);
    }
}

