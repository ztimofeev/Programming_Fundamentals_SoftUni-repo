using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestIncreasingSubsequence
{
    public class LargestIncreasingSubsequence
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> lis = new List<int>();
            int[] result = new int[1];
            lis.Add(numbers[0]);
            result[0] = numbers[0];
            var maxLen = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > lis[lis.Count - 1])
                {
                    lis.Add(numbers[i]);
                }
                else if (numbers[i] < lis[lis.Count - 1] && !lis.Contains(numbers[i]) && numbers[i] >= 0)
                {
                    lis.Add(numbers[i]);
                    lis.Sort();
                    var index = lis.IndexOf(numbers[i]);
                    lis = lis.Take(index + 1).ToList();
                }

                if (lis.Count > maxLen)
                {
                    maxLen = lis.Count;
                    result = lis.ToArray();
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
