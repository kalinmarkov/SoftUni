using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = 1;
        int dashes = (n - stars) / 2;
        //top
        if (n % 2 == 0)
        {
            stars = 2;
        }

            for (int i = 0; i < (n + 1) / 2; i++)
        {
            
                Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars), new string('*', dashes));
                stars += 2;
                dashes--;     
        }
        
        
        
        //bottom
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("|{0}|", new string('*', n - 2));
        }
    }
}

