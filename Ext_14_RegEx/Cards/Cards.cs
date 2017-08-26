using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cards
{
    public class Cards
    {
        public static void Main()
        {
            Regex pattern = new Regex(@"(^|(?<=[SHDC]))([2-9JKQA]|(10))[SHDC]");
            

            string cards = Console.ReadLine();

            MatchCollection matchedCards = pattern.Matches(cards);

            List<string> result = matchedCards
                .Cast<Match>()
                .Select(x => x.Value)
                .ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
