using System;

public class Program
{
    public static void Main()
    {
        string variableInHex = Console.ReadLine();
        int number = Convert.ToInt32(variableInHex, 16);

        Console.WriteLine(number);
    }
}

