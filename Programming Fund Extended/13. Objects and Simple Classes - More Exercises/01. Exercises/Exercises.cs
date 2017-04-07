using System;
using System.Collections.Generic;
using System.Linq;

class Exercise
{
    public string Topic { get; set; }

    public string CourseName { get; set; }

    public string JudgeContestLink { get; set; }

    public List<string> Problem { get; set; }

}

class Exercises
{
    static void Main()
    {
        var exercisesDatabase = new List<Exercise>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "go go go")
            {
                break;
            }

            var tokens = input.Split(", ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var topic = tokens[0];
            var courseName = tokens[1];
            var judgeContestLink = tokens[2];
            var problem = tokens.Skip(3).ToList();

            var newExercise = new Exercise()
            {
                Topic = topic,
                CourseName = courseName,
                JudgeContestLink = judgeContestLink,
                Problem = problem
            };

            exercisesDatabase.Add(newExercise);
        }
        
        foreach (Exercise exercise in exercisesDatabase)
        {
            Console.WriteLine($"Exercises: {exercise.Topic}");
            Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.\r\nCheck your solutions here: {exercise.JudgeContestLink}");

            var count = 1;
            foreach (var item in exercise.Problem)
            {
                Console.WriteLine($"{count}. {item}");
                count++;
            }
        }
        
    }
}


