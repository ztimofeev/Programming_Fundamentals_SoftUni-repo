namespace ShellBound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShellBound
    {
        public static void Main()
        {
            Dictionary<string, HashSet<int>> regionsAndShells = new Dictionary<string, HashSet<int>>();
            var inputData = Console.ReadLine().Split();
            
            while (inputData[0] != "Aggregate")
            {
                var region = inputData[0];
                var shellSize = int.Parse(inputData[1]);

                if (! regionsAndShells.ContainsKey(region))
                {
                    regionsAndShells.Add(region, new HashSet<int>());
                }

                regionsAndShells[region].Add(shellSize);

                inputData = Console.ReadLine().Split();
            }

            foreach (var item in regionsAndShells)
            {
                var gaintShell = item.Value.Sum() - (int)item.Value.Average();
                Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)} ({gaintShell})");
            }
        }
    }
}
