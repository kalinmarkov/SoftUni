using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dog
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int NumberOfLegs { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
    }
}

class Cat
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int IntelligenceQuotient { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
    }
}

class Snake
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int CrueltyCoefficient { get; set; }

    public void ProduceSound()
    {
        Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
    }
}

class Animals
{
    static void Main()
    {
        var dogs = new Dictionary<string, Dog>();
        var cats = new Dictionary<string, Cat>();
        var snakes = new Dictionary<string, Snake>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "I'm your Huckleberry")
            {
                break;
            }

            var tokens = input.Split();

            if (tokens[0] != "talk")
            {
                var classAnimal = tokens[0];
                var name = tokens[1];
                var age = int.Parse(tokens[2]);
                var parameter = int.Parse(tokens[3]);

                switch (classAnimal)
                {
                    case "Dog":
                        var newDog = new Dog()
                        {
                            Name = name,
                            Age = age,
                            NumberOfLegs = parameter
                        };

                        dogs.Add(newDog.Name, newDog);
                        break;
                    case "Cat":
                        var newCat = new Cat()
                        {
                            Name = name,
                            Age = age,
                            IntelligenceQuotient = parameter
                        };

                        cats.Add(newCat.Name, newCat);
                        break;
                    case "Snake":
                        var newSnake = new Snake()
                        {
                            Name = name,
                            Age = age,
                            CrueltyCoefficient = parameter
                        };

                        snakes.Add(newSnake.Name, newSnake);
                        break;
                }
            }
            else
            {
                var animalName = tokens[1];

                if (dogs.ContainsKey(animalName))
                {
                    dogs[animalName].ProduceSound();
                }
                else if (cats.ContainsKey(animalName))
                {
                    cats[animalName].ProduceSound();
                }
                else if (snakes.ContainsKey(animalName))
                {
                    snakes[animalName].ProduceSound();
                }
            }
            
        }

        foreach (var dog in dogs.Values)
        {
            var name = dog.Name;
            var age = dog.Age;
            var numberOfLegs = dog.NumberOfLegs;
            Console.WriteLine($"Dog: {name}, Age: {age}, Number Of Legs: {numberOfLegs}");
        }

        foreach (var cat in cats.Values)
        {
            var name = cat.Name;
            var age = cat.Age;
            var intelligenceQontient = cat.IntelligenceQuotient;
            Console.WriteLine($"Cat: {name}, Age: {age}, IQ: {intelligenceQontient}");
        }

        foreach (var snake in snakes.Values)
        {
            var name = snake.Name;
            var age = snake.Age;
            var crueltyCoefficient = snake.CrueltyCoefficient;
            Console.WriteLine($"Snake: {name}, Age: {age}, Cruelty: {crueltyCoefficient}");
        }
    }
}

