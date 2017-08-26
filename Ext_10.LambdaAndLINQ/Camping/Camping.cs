namespace Camping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Camping
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> personsWithCampers = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputData = inputLine.Split().ToArray();
                var personsName = inputData[0];
                var camperModel = inputData[1];
                var timeToStay = int.Parse(inputData[2]);

                if (! personsWithCampers.ContainsKey(personsName))
                {
                    personsWithCampers[personsName] = new Dictionary<string, int>();
                }

                if (! personsWithCampers[personsName].ContainsKey(camperModel))
                {
                    personsWithCampers[personsName][camperModel] = 0;
                }

                personsWithCampers[personsName][camperModel] += timeToStay;

                inputLine = Console.ReadLine();
            }

            var orderedPersonAndCampers = personsWithCampers
                                            .OrderByDescending(x => x.Value.Count)
                                            .ThenBy(x => x.Key.Length)
                                            .ToDictionary(x => x.Key, x => x.Value);


            foreach (var personsWithCamper in orderedPersonAndCampers)
            {
                var personName = personsWithCamper.Key;
                var campers = personsWithCamper.Value;

                Console.WriteLine($"{personName}: {campers.Count}");
                foreach (var camper in campers)
                {
                    Console.WriteLine($"***{camper.Key}");
                }
                Console.WriteLine($"Total stay: {campers.Select(x => x.Value).Sum()} nights");
            }
        }
    }
}
