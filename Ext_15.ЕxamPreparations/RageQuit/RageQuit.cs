using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();

            Regex regex = new Regex(@"([^0-9]+[0-9]+)");
            Regex regexString = new Regex(@"[^0-9]+");
            Regex regexDigit = new Regex(@"[0-9]+");

            List<char> uniqs = new List<char>();
            StringBuilder result = new StringBuilder();

            var matchesInput = regex.Matches(input);

            string[] matchesToArray = matchesInput
                .Cast<Match>()
                .Select(x => x.Value).ToArray();

            foreach (var match in matchesToArray)
            {
                string str = regexString.Match(match).Value;

                int repetitionCount = int.Parse(regexDigit.Match(match).Value);

                foreach (var ch in str)
                {
                    if (!uniqs.Contains(ch) && repetitionCount > 0)
                    {
                        uniqs.Add(ch);
                    }
                }

                result.Append(RepetitionMaker(str, repetitionCount));
            }
                
            Console.WriteLine($"Unique symbols used: {uniqs.Count}");
            Console.WriteLine(result.ToString());
        }

        public static string RepetitionMaker(string str, int repetitionCount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < repetitionCount; i++)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }
    }
}
