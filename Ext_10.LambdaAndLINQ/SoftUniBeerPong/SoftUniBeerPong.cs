namespace SoftUniBeerPong
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniBeerPong
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> beerTeams = new Dictionary<string, Dictionary<string, int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "stop the game")
            {
                var tokens = inputLine.Split('|');
                var player = tokens[0];
                var team = tokens[1];
                var points = int.Parse(tokens[2]);

                if (!beerTeams.ContainsKey(team))
                {
                    beerTeams[team] = new Dictionary<string, int>();
                }

                if (beerTeams[team].Count < 3)
                {
                    beerTeams[team][player] = points;
                }

                inputLine = Console.ReadLine();
            }

            var validBeerTeams = beerTeams.Where(x => x.Value.Count == 3).ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, int> teamResults = new Dictionary<string, int>();
            var totalPoints = 0;

            foreach (var team in validBeerTeams)
            {
                var teamName = team.Key;
                var teamPlayersAndPoints = team.Value;

                foreach (var item in teamPlayersAndPoints)
                {
                    totalPoints += item.Value;
                }

                teamResults.Add(teamName, totalPoints);
                totalPoints = 0;
            }

            var counter = 1;

            foreach (var team in teamResults.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{counter}. {team.Key}; Players:");
                counter++;

                foreach (var item in validBeerTeams)
                {
                    if (item.Key == team.Key)
                    {
                        var teamPlayers = item.Value.OrderByDescending(x => x.Value);
                        foreach (var kvp in teamPlayers)
                        {
                            Console.WriteLine($"###{kvp.Key}: {kvp.Value}");
                        }
                    }
                }
            }
        }
    }
}
