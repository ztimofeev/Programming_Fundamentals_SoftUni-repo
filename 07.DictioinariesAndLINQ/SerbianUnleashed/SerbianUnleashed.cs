using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SerbianUnleashed
{
    public class SerbianUnleashed
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> geekData = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string correctInputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

                if (Regex.IsMatch(input, correctInputPattern))
                {
                    Match match = Regex.Match(input, correctInputPattern);

                    string singer = match.Groups[1].Value.Trim();
                    string venue = match.Groups[3].Value.Trim();
                    int ticketsPrice = int.Parse(match.Groups[5].Value);
                    int ticketsCount = int.Parse(match.Groups[6].Value);

                    int totalMoney = ticketsCount * ticketsPrice;

                    if (!geekData.ContainsKey(venue))
                    {
                        geekData.Add(venue, new Dictionary<string, int>() { { singer, totalMoney } });
                    }
                    else if (!geekData[venue].ContainsKey(singer))
                    {
                        geekData[venue].Add(singer, totalMoney);
                    }
                    else
                    {
                        geekData[venue][singer] += totalMoney;
                    }
                }

            }

            foreach (var dataLine in geekData)
            {
                Console.WriteLine(dataLine.Key);

                foreach (var singer in dataLine.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }
    }
}