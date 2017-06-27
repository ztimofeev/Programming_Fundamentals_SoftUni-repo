namespace Index_of_Letters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] letters = new char[26];

            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)(97 + i);
            }

            string input = Console.ReadLine().ToLower();

            foreach (var item in input)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (item == letters[i])
                    {
                        Console.WriteLine($"{item} -> {i}");
                    }
                }
            }
        }
    }
}
