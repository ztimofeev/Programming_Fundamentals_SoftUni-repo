namespace ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForumTopics
    {
        public static void Main()
        {
            Dictionary<string, HashSet<string>> resultData = new Dictionary<string, HashSet<string>>();

            var input = Console.ReadLine();

            while (input != "filter")
            {
                var inputTokens = input.Split(new [] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                var topic = inputTokens[0];
                var tags = inputTokens[1].Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries);

                if (! resultData.ContainsKey(topic))
                {
                    resultData.Add(topic, new HashSet<string>());
                }

                foreach (var tag in tags)
                {
                    resultData[topic].Add(tag);
                }

                input = Console.ReadLine();
            }

            var filter = Console.ReadLine().Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in resultData)
            {
                var topic = item.Key;
                var tags = item.Value;
                bool isContains = true;

                foreach (var token in filter)
                {
                    if (! tags.Contains(token))
                    {
                        isContains = false;
                        break;
                    }
                }

                if (isContains)
                {
                    Console.Write($"{topic} | ");
                    foreach (var tag in tags)
                    {
                        if (tag != tags.Last())
                        {
                            Console.Write($"#{tag}, ");
                        }
                        else
                        {
                            Console.Write($"#{tag}");
                        }
                        
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
