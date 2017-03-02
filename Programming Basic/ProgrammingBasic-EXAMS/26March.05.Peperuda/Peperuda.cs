using System;

class Peperuda
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string asterisks = new string('*', n - 2);
        string dashes = new string('-', n - 2);
        string whiteSpaces = new string(' ', n - 1);


        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(asterisks + "\\ /" + asterisks);
            }
            else
            {
                Console.WriteLine(dashes + "\\ /" + dashes);
            }
            
        }

        Console.WriteLine(whiteSpaces + "@");

        for (int i = 0; i < n - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(asterisks + "/ \\" + asterisks);
            }
            else
            {
                Console.WriteLine(dashes + "/ \\" + dashes);
            }
        }
    }
}

