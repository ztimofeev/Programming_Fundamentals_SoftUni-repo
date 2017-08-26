namespace PointsCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PointsCounter
    {
        static void Main()
        {
            var input = Console.ReadLine();
            
            Dictionary<string, Dictionary<string, int>> teamsResults = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Result")
            {
                var inputTokens = input.Split('|');
                var firstToken = ClearingString(inputTokens[0]);
                var secondToken = ClearingString(inputTokens[1]);
                var score = int.Parse(inputTokens[2]);

                string teamName;
                string playerName;

                if (firstToken == firstToken.ToUpper())
                {
                    teamName = firstToken;
                    playerName = secondToken;
                }
                else
                {
                    teamName = secondToken;
                    playerName = firstToken;
                }

                if (! teamsResults.ContainsKey(teamName))
                {
                    teamsResults[teamName] = new Dictionary<string, int>();
                }

                if (! teamsResults[teamName].ContainsKey(playerName))
                {
                    teamsResults[teamName][playerName] = 0;
                }

                teamsResults[teamName][playerName] = score;

                input = Console.ReadLine();
            }

            teamsResults = teamsResults
                                .OrderByDescending(x => x.Value.Values.Sum())
                                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var teamsResult in teamsResults)
            {
                var teamName = teamsResult.Key;
                var teamPlayersPoints = teamsResult
                                            .Value
                                            .OrderByDescending(x => x.Value)
                                            .ToDictionary(x => x.Key, x => x.Value);

                var bestResult = teamPlayersPoints.Values.Sum();
                var bestPlayer = teamPlayersPoints.Keys.First();

                Console.WriteLine($"{teamName} => {bestResult}");
                Console.WriteLine($"Most points scored by {bestPlayer}");
            }
        }

        public static string ClearingString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (! char.IsLetter(str[i]))
                {
                    str = str.Remove(i, 1);
                    i--;
                }
            }

            return str;
        }
    }
}
