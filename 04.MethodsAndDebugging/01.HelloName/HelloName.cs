namespace _01.HelloName
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();

            PrintGreeting(name);
        }

        public static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
