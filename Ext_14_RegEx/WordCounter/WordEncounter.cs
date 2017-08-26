using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordEncounter
{
    public class WordEncounter
    {
        public static void Main()
        {
            var patternSentence = @"^[A-Z].*[\.\?\!]$";


            List<string> result = new List<string>();

            string filter = Console.ReadLine();

            var letter = filter[0];
            var count = filter[1] - '0';

            Regex regex = new Regex(patternSentence);

            var sentence = Console.ReadLine();

            while (sentence != "end")
            {
                if (regex.IsMatch(sentence))
                {
                    var separators = @"\W+";

                    var words = Regex.Split(sentence, separators);

                    foreach (var word in words)
                    {
                        if (IsPassFilter(word, count, letter) && word != "")
                        {
                            result.Add(word);
                        }
                    }
                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));
        }

        public static bool IsPassFilter(string word, int count, char letter)
        {
            int counter = 0;

            foreach (var ch in word)
            {
                if (ch == letter)
                {
                    counter++;
                }
            }

            if (counter >= count)
            {
                return true;
            }
            return false;
        }
    }
}
