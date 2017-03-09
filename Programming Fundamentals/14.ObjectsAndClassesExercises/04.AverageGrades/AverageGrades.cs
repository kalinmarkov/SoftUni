using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }

    public List<double> Grades { get; set; }

    public double AverageGrade
    {
        get
        {
            return this.Grades.Average();
        }
    }

    public Student(string name, List<double> grades)
    {
        this.Name = name;
        this.Grades = grades;
    }

    public static List<Student> ReadSrudents(int numberOfStudents)
    {
        var students = new List<Student>();
        for (int i = 0; i < numberOfStudents; i++)
        {
            var currentStudent = Console.ReadLine().Split();
            var name = currentStudent[0];
            var studentGrades = new List<double>();
            studentGrades.AddRange(currentStudent.Where((x, index) => index > 0).Select(double.Parse));
            var student = new Student(name, studentGrades);
            students.Add(student);
        }
        return students;
    }
}

class AverageGrades
{
    static void Main()
    {
        int numberOfStudents = int.Parse(Console.ReadLine());

        var students = new List<Student>();
        students = Student.ReadSrudents(numberOfStudents);

        var topStudents = students
                  .Where(x => x.AverageGrade >= 5.00)
                  .OrderBy(x => x.Name)
                  .ThenByDescending(x => x.AverageGrade)
                  .ToList();

        foreach (var student in topStudents)
        {
            Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
        }
    }

}

