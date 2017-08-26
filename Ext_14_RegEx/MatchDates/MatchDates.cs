using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    public class MatchDates
    {
        public static void Main()
        {
            Regex pattern = new Regex(@"\b(?<day>\d{2})([\/\-.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

            string datesAsString = Console.ReadLine();

            var dates = pattern.Matches(datesAsString);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
