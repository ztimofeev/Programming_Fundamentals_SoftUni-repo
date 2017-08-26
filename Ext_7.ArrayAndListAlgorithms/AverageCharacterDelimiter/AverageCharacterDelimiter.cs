namespace AverageCharacterDelimiter
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var text = new List<char>();

            foreach (var member in input)
            {
                text.AddRange(member);
            }

            var sumOfASCII = 0;
            var count = 0;

            foreach (var item in text)
            {
                sumOfASCII += item;
                count += 1;
            }

            sumOfASCII = sumOfASCII / count;
            var delimiter = (char)sumOfASCII;

            if (char.IsLetter(delimiter))
            {
                delimiter = char.ToUpper(delimiter);
            }

            Console.WriteLine(string.Join($"{delimiter}", input));
        }
    }
}
