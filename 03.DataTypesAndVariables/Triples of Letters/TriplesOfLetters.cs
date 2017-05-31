namespace Triples_of_Letters
{
    using System;

    public class TriplesOfLetters
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < ('a' + n); i++)
            {
                for (int j = 'a'; j < ('a' + n); j++)
                {
                    for (int k = 'a'; k < ('a' + n); k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
