namespace LogsAggregator
{
    using System;
    using System.Collections.Generic;

    public class LogsAggregator
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> logsAggregator = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var user = input[1];
                var ip = input[0];
                var duration = int.Parse(input[2]);


                if (! logsAggregator.ContainsKey(user))
                {
                    logsAggregator[user] = new SortedDictionary<string, int>();
                }

                if (! logsAggregator[user].ContainsKey(ip))
                {
                    logsAggregator[user][ip] = 0;
                }

                logsAggregator[user][ip] += duration;
            }

            foreach (var user in logsAggregator)
            {
                var userName = user.Key;
                var totalDuration = 0;
                List<string> usersIp = new List<string>();
                
                foreach (var item in user.Value)
                {
                    var particularIp = item.Key;
                    totalDuration += item.Value;
                    if (!usersIp.Contains(particularIp))
                    {
                        usersIp.Add(particularIp);
                    }
                }

                Console.WriteLine("{0}: {1} [{2}]", userName, totalDuration, string.Join(", ", usersIp));
            }
        }
    }
}
