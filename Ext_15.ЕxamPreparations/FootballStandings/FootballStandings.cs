using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FootballStandings
{
    public class FootballStandings
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string escapedKey = Regex.Escape(key);

            string pattern = string.Format(@".*(?<={0})([a-zA-Z]*)(?={0}).*(?<={0})([a-zA-Z]*)(?={0})[^ ]+ (\d+):(\d+)", escapedKey);
            Regex regex = new Regex(pattern);

            Dictionary<string, long> teamGoals = new Dictionary<string, long>();
            Dictionary<string, long> teamScores = new Dictionary<string, long>();

            var input = Console.ReadLine();
            
            while (input.ToUpper() != "FINAL")
            {
                Match inputMatches = regex.Match(input);
                
                string teamA = MakeString(inputMatches.Groups[1].Value.ToUpper().Reverse());
                string teamB= MakeString(inputMatches.Groups[2].Value.ToUpper().Reverse());
                long goalsTeamA = long.Parse(inputMatches.Groups[3].Value);
                long goalsTeamB = long.Parse(inputMatches.Groups[4].Value);
                long scoresTeamA = 0;
                long scoresTeamB = 0;

                if (goalsTeamA > goalsTeamB)
                {
                    scoresTeamA = 3;
                }
                else if (goalsTeamA < goalsTeamB)
                {
                    scoresTeamB = 3;
                }
                else
                {
                    scoresTeamA = 1;
                    scoresTeamB = 1;
                }

                SetTeamResults(teamGoals, teamScores, teamA, goalsTeamA, scoresTeamA);
                SetTeamResults(teamGoals, teamScores, teamB, goalsTeamB, scoresTeamB);
                
                input = Console.ReadLine();
            }

            int counter = 1;
            
            var sortedTeamsByScores = teamScores
                .OrderByDescending(x => x.Value)
                .ThenBy(y => y.Key);

            Console.WriteLine("League standings:");
            foreach (var team in sortedTeamsByScores)
            {
                var teamName = team.Key;
                var points = team.Value;
                Console.WriteLine($"{counter}. {teamName} {points}");
                counter++;
            }

            var firstThreePlaces = teamGoals
                .OrderByDescending(x => x.Value)
                .ThenBy(y => y.Key)
                .Take(3);

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in firstThreePlaces)
            {
                var teamName = team.Key;
                var goals = team.Value;
                Console.WriteLine($"- {teamName} -> {goals}");
            }
        }

        private static void SetTeamResults(Dictionary<string, long> teamGoals, 
            Dictionary<string, long> teamScores, string teamName, long goals, long scores)
        {
            if (!teamGoals.ContainsKey(teamName))
            {
                teamGoals[teamName] = 0;
            }
            teamGoals[teamName] += goals;

            if (! teamScores.ContainsKey(teamName))
            {
                teamScores[teamName] = 0;
            }
            teamScores[teamName] += scores;
        }

        private static string MakeString(IEnumerable<char> team)
        {
            string str = "";
            foreach (var ch in team)
            {
                str += ch;
            }
            return str;
        }
    }
}
