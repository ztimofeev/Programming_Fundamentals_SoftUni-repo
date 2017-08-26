using System;
using System.Collections.Generic;
using System.Linq;

namespace Websites
{
    public class Website
    {
        public Website(string host, string domain)
        {
            Host = host;
            Domain = domain;
            Queries = null;
        }

        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }

    public class Websites
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var websites = new List<Website>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new [] {" | "}, StringSplitOptions.RemoveEmptyEntries);
                var domain = tokens[0];
                var host = tokens[1];

                if (tokens.Length > 2)
                {
                    var queries = tokens[2].Split(',', ' ').ToList();

                    var website = new Website(host, domain)
                    {
                        Queries = queries
                    };

                    websites.Add(website);
                }
                else
                {
                    websites.Add(new Website(host, domain));
                }

                inputLine = Console.ReadLine();
            }

            foreach (var record in websites)
            {
                if (record.Queries != null)
                {
                    Console.Write(@"https://www.{0}.{1}/query?=", record.Domain, record.Host);
                    
                    var listOfQueries = record.Queries;
                    foreach (var query in listOfQueries)
                    {
                        if (query != listOfQueries[listOfQueries.Count - 1])
                        {
                            Console.Write($"[{query}]&");
                        }
                        else
                        {
                            Console.Write($"[{query}]");
                        }
                    }
                }
                else
                {
                    Console.Write(@"https://www.{0}.{1}", record.Domain, record.Host);
                }

                Console.WriteLine();
            }
        }
    }
}
