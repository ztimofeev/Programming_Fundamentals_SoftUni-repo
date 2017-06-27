namespace Max_Sequence_of_Increasing_Elements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bestIndex = 0;
            var bestCount = 0;
            var counter = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    counter++;
                    if (counter > bestCount)
                    {
                        bestCount = counter;
                        bestIndex = i - counter + 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            var len = bestCount + bestIndex;
            for (int i = bestIndex; i < len; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
