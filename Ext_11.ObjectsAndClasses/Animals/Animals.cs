using System;
using System.Collections.Generic;

namespace Animals
{
    public class Dog
    {
        public Dog(string name, int age, int numberOfLegs)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    public class Cat
    {
        public Cat(string name, int age, int intelligenceQuotient)
        {
            Name = name;
            Age = age;
            IntelligenceQuotient = intelligenceQuotient;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    public class Snake
    {
        public Snake(string name, int age, int crueltyCoefficient)
        {
            Name = name;
            Age = age;
            CrueltyCoefficient = crueltyCoefficient;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    public class Animals
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Snake> snakes = new List<Snake>();

            while (inputLine != "I'm your Huckleberry")
            {
                var tokens = inputLine.Split();

                if (tokens[0] != "talk")
                {
                    var animal = tokens[0];
                    var name = tokens[1];
                    var age = int.Parse(tokens[2]);
                    var param = int.Parse(tokens[3]);

                    switch (animal)
                    {
                        case "Dog":
                            var dog = new Dog(name, age, param);
                            dogs.Add(dog);
                            break;

                        case "Cat":
                            var cat = new Cat(name, age, param);
                            cats.Add(cat);
                            break;

                        case "Snake":
                            var snake = new Snake(name, age, param);
                            snakes.Add(snake);
                            break;
                    }
                }
                else
                {
                    var currectName = tokens[1];

                    foreach (var dog in dogs)
                    {
                        if (dog.Name == currectName)
                        {
                            dog.ProduceSound();
                        }
                    }

                    foreach (var cat in cats)
                    {
                        if (cat.Name == currectName)
                        {
                            cat.ProduceSound();
                        }
                    }

                    foreach (var snake in snakes)
                    {
                        if (snake.Name == currectName)
                        {
                            snake.ProduceSound();
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
