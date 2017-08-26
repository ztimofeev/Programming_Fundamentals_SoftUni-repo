using System;
using System.Collections.Generic;
using System.Linq;

namespace UnionLists
{
    public class UnionLists
    {
        public static void Main()
        {
            var primal = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentList = Console.ReadLine().Split().Select(int.Parse).ToList();

                List<int> numbersForReplacing = new List<int>();

                for (var j = 0; j < currentList.Count; j++)
                {
                    if (! primal.Contains(currentList[j]))
                    {
                        primal.Add(currentList[j]);
                        numbersForReplacing.Add(currentList[j]);
                    }
                }

                for (var j = 0; j < numbersForReplacing.Count; j++)
                {
                    currentList.Remove(numbersForReplacing[j]);
                }

                for (var j = 0; j < currentList.Count; j++)
                {
                    if (primal.Contains(currentList[j]))
                    {
                        primal.Remove(currentList[j]);
                        j--;
                    }
                }
            }

            primal.Sort();

            Console.WriteLine(string.Join(" ", primal));
        }
    }
}
