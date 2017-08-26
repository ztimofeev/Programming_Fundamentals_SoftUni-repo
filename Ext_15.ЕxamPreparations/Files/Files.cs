using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Files
{
    public class Files
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, long>> files = 
                new Dictionary<string, Dictionary<string, long>>();

            Regex regex = new Regex(@"^([^\W-]+:?)\\?[\w+\\]*\\(.+);([0-9]+)$");

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine();

                Match matchedInput = regex.Match(input);
                string rootAndPath = matchedInput.Groups[1].Value;
                string fileName = matchedInput.Groups[2].Value;
                long fileSize = long.Parse(matchedInput.Groups[3].Value);

                if (! files.ContainsKey(rootAndPath))
                {
                    files.Add(rootAndPath, new Dictionary<string, long>());
                }

                if (! files[rootAndPath].ContainsKey(fileName))
                {
                    files[rootAndPath][fileName] = 0;
                }

                files[rootAndPath][fileName] = fileSize;
            }

            string[] fileNameAndExtention = Console.ReadLine().Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries);

            string root = fileNameAndExtention[1];
            string ext = fileNameAndExtention[0];

            var filterdedFiles = files
                .Where(r => r.Key == root)
                .ToDictionary(x=> x.Key, x => x.Value);
            
            Dictionary<string, decimal> resultToPrint = new Dictionary<string, decimal>();

            if (!files.ContainsKey(root))
            {
                Console.WriteLine("No");
                return;
            }

            foreach (var token in filterdedFiles)
            {
                foreach (var kvp in token.Value)
                {
                    var fileExtention = kvp.Key.Split('.').Last();

                    if (fileExtention == ext)
                    {
                        if (! resultToPrint.ContainsKey(kvp.Key))
                        {
                            resultToPrint[kvp.Key] = 0;
                        }

                        resultToPrint[kvp.Key] = kvp.Value;
                    }
                }
            }

            if (resultToPrint.Count > 0)
            {
                foreach (var record in resultToPrint.OrderByDescending(size => size.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{record.Key} - {record.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
