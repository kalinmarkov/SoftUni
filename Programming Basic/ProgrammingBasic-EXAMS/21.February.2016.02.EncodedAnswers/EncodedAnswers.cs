using System;

class EncodedAnswers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int answerA = 0;
        int answerB = 0;
        int answerC = 0;
        int answerD = 0;
        string result = null;

        for (int i = 0; i < n; i++)
        {
            uint num = uint.Parse(Console.ReadLine());
            string answer = null;
            if (num % 4 == 0)
            {
                answerA++;
                answer = "a";
            }
            else if (num % 4 == 1)
            {
                answerB++;
                answer = "b";
            }
            else if (num % 4 == 2)
            {
                answerC++;
                answer = "c";
            }
            else if (num % 4 == 3)
            {
                answerD++;
                answer = "d";
            }

            result += answer + ' ';
        }
        Console.WriteLine(result);
        Console.WriteLine($"Answer A: {answerA}");
        Console.WriteLine($"Answer B: {answerB}");
        Console.WriteLine($"Answer C: {answerC}");
        Console.WriteLine($"Answer D: {answerD}");

    }
}

