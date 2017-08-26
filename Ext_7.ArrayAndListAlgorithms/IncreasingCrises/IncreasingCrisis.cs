namespace IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            List<int> incresingSequence = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                var currentNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

                if (incresingSequence.Count > 0)
                {
                    for (int j = incresingSequence.Count - 1; j >= 0 ; j--)
                    {
                        if (incresingSequence[j] <= currentNumbers[0])
                        {
                            if (i != n - 1)
                            {
                                incresingSequence.InsertRange(j + 1, currentNumbers);
                            }
                            else
                            {
                                incresingSequence.RemoveRange(j + 1, incresingSequence.Count - (j + 1));
                                incresingSequence.InsertRange(j + 1, currentNumbers);
                            }

                            break;
                        } 
                    }
                }
                else
                {
                    incresingSequence.AddRange(currentNumbers);
                }

                if (incresingSequence[0] > currentNumbers[0])
                {
                    incresingSequence.InsertRange(0, currentNumbers);
                }

                CheckIncreasing(incresingSequence);
            }

            Console.WriteLine(string.Join(" ", incresingSequence));
        }

        public static List<int> CheckIncreasing(List<int> increasingList)
        {
            for (int i = 1; i < increasingList.Count; i++)
            {
                if (increasingList[i] < increasingList[i - 1])
                {
                    increasingList.RemoveRange(i, increasingList.Count - i);
                }
            }
            
            return increasingList;
        }
    }
}