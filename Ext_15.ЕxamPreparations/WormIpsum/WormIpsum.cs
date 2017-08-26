using System;
using System.Collections.Generic;
using System.Linq;

namespace WormIpsum
{
    public class WormIpsum
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();

            while (sentence != "Worm Ipsum")
            {
                bool isValid = ValidationText(sentence);
                if (isValid)
                {
                    List<string> changedSentense = new List<string>();
                    sentence = sentence.Remove(sentence.Length - 1);
                    var sentenceParts = sentence.Split( ' ' );

                    foreach (var part in sentenceParts)
                    {
                        var word = ProccessingWord(part);
                        changedSentense.Add(word);
                    }

                    Console.WriteLine($"{string.Join(" ", changedSentense)}.");
                    
                }

                sentence = Console.ReadLine();
            }
        }

        public static bool ValidationText(string str)
        {
            var firstLetter = str[0];
            var dotPosition = str.IndexOf(".");

            if (char.IsUpper(firstLetter) && dotPosition == str.Length - 1)
            {
                return true;
            }
            
            return false;
        }

        private static string ProccessingWord(string part)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            string resultWord = part;

            foreach (var ch in part)
            {
                if (char.IsLetter(ch))
                {
                    if (! charCount.ContainsKey(ch))
                    {
                        charCount[ch] = 0;
                    }
                    charCount[ch] += 1;
                }
            }

            var orderedDict = charCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int count = orderedDict.First().Value;
            char symbol = orderedDict.First().Key;
            
            if (count > 1)
            {
                if (! char.IsLetter(part[part.Length - 1]))
                {
                    var lastSymbol = part[part.Length - 1] + "";
                    resultWord = new string(symbol, part.Length - 1) + lastSymbol;
                }
                else
                {
                    resultWord = new string(symbol, part.Length);
                }
            }

            return resultWord;
        }
    }
}
