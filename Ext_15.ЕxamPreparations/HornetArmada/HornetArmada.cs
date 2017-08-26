using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetArmada
{
    public class HornetArmada
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> legionsWithActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> legionsWithSoldiers = new Dictionary<string, Dictionary<string, long>>();

            Regex regex = new Regex(@"^(\d+)\s=\s(.+)\s-\>\s(.+):(\d+)$");

            for (int i = 0; i < n; i++)
            {
                var matchedInput = regex.Match(Console.ReadLine());

                int lastActivity = int.Parse(matchedInput.Groups[1].Value);
                string legionName = matchedInput.Groups[2].Value;
                string soldiersType = matchedInput.Groups[3].Value;
                int soldiersCount = int.Parse(matchedInput.Groups[4].Value);

                if (! legionsWithActivity.ContainsKey(legionName))
                {
                    legionsWithActivity.Add(legionName, lastActivity);
                    legionsWithSoldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (lastActivity > legionsWithActivity[legionName])
                {
                    legionsWithActivity[legionName] = lastActivity;
                }

                if (! legionsWithSoldiers[legionName].ContainsKey(soldiersType))
                {
                    legionsWithSoldiers[legionName][soldiersType] = 0;
                }

                legionsWithSoldiers[legionName][soldiersType] += soldiersCount;
            }

            var command = Console.ReadLine().Split('\\');

            if (command.Length > 1)
            {
                var limitActivity = int.Parse(command[0]);
                var soldierType = command[1];

                foreach (var record in legionsWithSoldiers
                    .Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value[soldierType]))
                {
                    var legionName = record.Key;
                    if (legionsWithActivity[legionName] < limitActivity)
                    {
                        Console.WriteLine($"{legionName} -> {legionsWithSoldiers[legionName][soldierType]}");
                    }
                }
            }
            else
            {
                var soldierType = command[0];
                foreach (var record in legionsWithActivity.OrderByDescending(x => x.Value))
                {
                    var lastActivity = record.Value;
                    var legionName = record.Key;

                    if (legionsWithSoldiers[legionName].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{lastActivity} : {legionName}");
                    }
                }
            }
        }
    }
}
