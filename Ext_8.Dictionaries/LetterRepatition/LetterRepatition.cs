namespace LetterRepatition
{
    using System;
    using System.Collections.Generic;

    public class LetterRepatition
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var letter in text)
            {
                if (!result.ContainsKey(letter))
                {
                    result[letter] = 0;
                }

                result[letter] += 1;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> { kvp.Value}");
            }
        }
    }
}
