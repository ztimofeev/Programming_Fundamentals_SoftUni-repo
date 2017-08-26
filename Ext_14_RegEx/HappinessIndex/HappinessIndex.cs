using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main(string[] args)
        {
            Regex regexHappiness = new Regex(@"(?<happy>([\:|;|\(|\[|\*|c][\)|\]|\}|D|\*|:|;]))");
            Regex regexSadness = new Regex(@"(?<sad>([\:|;|\)|\]|D][\(|\{|\[|:|;|c]))");

            string input = Console.ReadLine();

            var happinessMatch = regexHappiness.Matches(input);
            int happinessCount = DeleteDoubledChar(happinessMatch);


            var sadnessMatch = regexSadness.Matches(input);
            int sadnessCount = DeleteDoubledChar(sadnessMatch);

            double happinessIndex = Math.Round((double)happinessCount / sadnessCount, 2);

            if (happinessIndex >= 2.00)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :D");
                
            }
            else if (happinessIndex > 1.00)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :)");
            }
            else if (happinessIndex == 1.00)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :|");
            }
            else
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :(");
            }
            Console.WriteLine($"[Happy count: {happinessCount}, Sad count: {sadnessCount}]");
        }

        public static int DeleteDoubledChar(MatchCollection collection)
        {
            int count = collection.Count;

            var arrayCollection = collection.Cast<Match>().Select(x => x.Value).ToArray();

            foreach (var item in arrayCollection)
            {
                if (item[0] == item[1])
                {
                    count--;
                }
            }

            return count;
        }
    }
}
