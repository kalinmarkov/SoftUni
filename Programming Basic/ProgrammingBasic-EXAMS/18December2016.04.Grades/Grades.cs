using System;

class Grades
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        int failCounter = 0;
        int middleCounter = 0;
        int goodCounter = 0;
        int topCounter = 0;
        double average = 0.0;

        for (int i = 0; i < students; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            average += grade;

            if (2 <= grade && grade < 3)
            {
                failCounter++;
            }
            else if (3 <= grade && grade < 4)
            {
                middleCounter++;
            }
            else if (4 <= grade && grade < 5)
            {
                goodCounter++;
            }
            else if (grade >= 5)
            {
                topCounter++;
            }

        }

        Console.WriteLine("Top students: {0:f2}%", topCounter / (double)students * 100);
        Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", goodCounter / (double)students * 100);
        Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", middleCounter / (double)students * 100);
        Console.WriteLine("Fail: {0:f2}%", failCounter / (double)students * 100);
        Console.WriteLine("Average: {0:f2}", average / students);
    }
}

