namespace CapitalizeWords
{
    using System;
    using System.Collections.Generic;

    public class CapitalizeWords
    {
        public static void Main()
        {
            var separators = new[]
            {
                '.', ',', '!', '?', ';', ':', '-', ' ', '/', '\\', '"'
                
            };
            var input = Console.ReadLine();

            while (input != "end")
            {
                List<string> capitalizedWords = new List<string>();

                var tokens = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (var token in tokens)
                {
                    capitalizedWords.Add(MakeCapitalizing(token));
                }

                Console.WriteLine(string.Join(", ", capitalizedWords));

                input = Console.ReadLine();
            }
        }

        private static string MakeCapitalizing(string word)
        {
            var firstLetter = word.Substring(0, 1).ToUpper();
            var restLetters = word.Substring(1).ToLower();
            return firstLetter + restLetters;
        }
    }
}
