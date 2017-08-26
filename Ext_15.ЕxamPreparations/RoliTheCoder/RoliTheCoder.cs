using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace RoliTheCoder
{
    public class RoliTheCoder
    {
        public static void Main()
        {
            Dictionary<int, Dictionary<string, List<string>>> events = new Dictionary<int, Dictionary<string, List<string>>>();

            

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (tokens.Skip(2).Any(x => !x.Contains("@"))) continue;
                if (!tokens[1].Contains("#")) continue;

                int id = int.Parse(tokens[0]);
                string eventName = tokens[1].Substring(1);

                var participants = tokens.Where(x => x.Contains("@")).ToList();

                if (events.ContainsKey(id))
                {
                    if (! events[id].ContainsKey(eventName))
                    {
                        continue;
                    }
                }

                if (! events.ContainsKey(id))
                {
                    events[id] = new Dictionary<string, List<string>>();
                }

                if (! events[id].ContainsKey(eventName))
                {
                    events[id][eventName] = new List<string>();
                }

                foreach (var participant in participants)
                {
                    if (! events[id][eventName].Contains(participant))
                    {
                        events[id][eventName].Add(participant);
                    }
                }
            }

            Dictionary<string, List<string>> results = events.SelectMany(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in results.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                var eventName = kvp.Key;
                var participantsCount = kvp.Value.Count;
                var participantsNames = kvp.Value;

                Console.WriteLine($"{eventName} - {participantsCount}");

                foreach (var name in participantsNames.OrderBy(x => x))
                {
                    Console.WriteLine($"{name}");
                }
            }
        }
    }
}
