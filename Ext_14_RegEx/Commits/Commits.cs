using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Commits
{
    class Commit
    {
        public string Hash{ get; set; }
        public string Message { get; set; }
        public int Addition { get; set; }
        public int Deletion { get; set; }

        public Commit(string hash, string message, int additions, int deletions)
        {
            this.Hash = hash;
            this.Message = message;
            this.Addition = additions;
            this.Deletion = deletions;
        }
    }
    
    public class Commits
    {
        public static void Main()
        {
            Regex regex = new Regex(@"^https:\/\/github\.com\/(?<userName>[A-Za-z0-9-]+)\/(?<repoName>[A-Za-z-_]+)\/commit\/(?<hash>[a-fA-F0-9]{40})\,(?<comment>.*[^\n])\,(?<addCount>[0-9]+)\,(?<delCount>[0-9]+)$");

            SortedDictionary<string, SortedDictionary<string, List<Commit>>> accounts = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            string input = Console.ReadLine();

            while (input != "git push")
            {

                if (regex.IsMatch(input))
                {
                    var inputMatch = regex.Match(input);

                    string user = inputMatch.Groups["userName"].Value;
                    string repo = inputMatch.Groups["repoName"].Value;
                    string hashSet = inputMatch.Groups["hash"].Value;
                    string comment = inputMatch.Groups["comment"].Value;
                    int additions = int.Parse(inputMatch.Groups["addCount"].Value);
                    int deletions = int.Parse(inputMatch.Groups["delCount"].Value);

                    Commit commit = new Commit(hashSet, comment, additions, deletions);

                    if (! accounts.ContainsKey(user))
                    {
                        accounts.Add(user, new SortedDictionary<string, List<Commit>>());
                    }

                    if (! accounts[user].ContainsKey(repo))
                    {
                        accounts[user].Add(repo, new List<Commit>());
                    }

                    accounts[user][repo].Add(commit);
                }

                input = Console.ReadLine();
            }

            foreach (var account in accounts)
            {
                var userName = account.Key;
                Console.WriteLine($"{userName}:");

                var repoContents = account.Value;
                foreach (var repo in repoContents)
                {
                    var repoName = repo.Key;
                    Console.WriteLine($"  {repoName}:");

                    var repoContent = repo.Value;
                    int totalAdds = repoContent.Sum(x => x.Addition);
                    int totalDels = repoContent.Sum(x => x.Deletion);

                    foreach (var record in repoContent)
                    {
                        Console.WriteLine($"    commit {record.Hash}: {record.Message} ({record.Addition} additions, {record.Deletion} deletions)");
                    }

                    Console.WriteLine($"    Total: {totalAdds} additions, {totalDels} deletions");
                }
            }
        }
    }
}
