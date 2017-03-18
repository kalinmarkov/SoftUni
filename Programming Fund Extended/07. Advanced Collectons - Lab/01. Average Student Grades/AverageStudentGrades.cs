using System;
using System.Collections.Generic;
using System.Linq;

class AverageStudentGrades
{
    static void Main()
    {
        var gradesList = new Dictionary<string, List<double>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var grade = double.Parse(input[1]);

            if (!gradesList.ContainsKey(name))
            {
                gradesList[name] = new List<double>();
            }
            gradesList[name].Add(grade);
        }

        foreach (var person in gradesList)
        {
            var name = person.Key;
            var grades = string.Join(" ", person.Value.Select(p => string.Format("{0:f2}", p)));
            var average = person.Value.Average();
            Console.WriteLine($"{name} -> {grades:f2} (avg: {average:f2})");
        }
    }
}

