namespace CottageScrapper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScrapper
    {
        public static void Main()
        {
            Dictionary<string, List<int>> treeLogs = new Dictionary<string, List<int>>();

            var inputLine = Console.ReadLine();
            var counter = 0;

            while (inputLine != "chop chop")
            {
                var inputArgs = inputLine.Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var kindTree = inputArgs[0];
                var heightTree = int.Parse(inputArgs[1]);

                if (!treeLogs.ContainsKey(kindTree))
                {
                    treeLogs.Add(kindTree, new List<int>());
                }

                treeLogs[kindTree].Add(heightTree);
                counter++;

                inputLine = Console.ReadLine();
            }

            double totalLenghtOfLogs = 0;

            foreach (KeyValuePair<string, List<int>> treeLog in treeLogs)
            {
                totalLenghtOfLogs += treeLog.Value.Sum();
            }

            double pricePerMeter = Math.Round(totalLenghtOfLogs / counter, 2);

            var neededTreeKind = Console.ReadLine();
            var minLenght = int.Parse(Console.ReadLine());

            var usedLogsPrice = treeLogs
                                        .Where(x => x.Key == neededTreeKind)
                                        .SelectMany(x => x.Value)
                                        .Where(x => x >= minLenght)
                                        .Sum() * pricePerMeter;

            usedLogsPrice = Math.Round(usedLogsPrice, 2);

            var unusedTreesLenght = treeLogs
                                        .Where(x => x.Key != neededTreeKind)
                                        .SelectMany(x => x.Value)
                                        .Sum() + 
                                    treeLogs
                                        .Where(x => x.Key == neededTreeKind)
                                        .SelectMany(x => x.Value)
                                        .Where(x => x < minLenght)
                                        .Sum();

            double unusedLogsPrice = Math.Round(unusedTreesLenght * pricePerMeter * 0.25, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${usedLogsPrice + unusedLogsPrice:F2}");
        }
    }
}
