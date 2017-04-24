using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public List<int> Grades { get; set; }

    public override string ToString()
    {
        return $"{{name:\"{this.Name}\",age:{this.Age},grades:[{string.Join(", ", this.Grades)}]}}";
    }
}

class JSONStringify
{
    static void Main()
    {
        var students = new List<Student>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "stringify")
            {
                break;
            }

            var tokens = input
                .Split(new char[] { ' ', ':', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = tokens[0];
            var age = int.Parse(tokens[1]);
            var grades = tokens.Skip(2).Select(int.Parse).ToList();

            var student = new Student
            {
                Name = name,
                Age = age,
                Grades = grades
            };
            
            students.Add(student);
            
            
        }

        Console.WriteLine($"[{string.Join(",", students)}]");
    }
}

