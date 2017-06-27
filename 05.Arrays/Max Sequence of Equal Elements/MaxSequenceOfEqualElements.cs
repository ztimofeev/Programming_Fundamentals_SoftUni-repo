namespace Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var bestValue = 0;
            var bestCount = 0;
            var counter = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    counter++;
                    if (counter > bestCount)
                    {
                        bestCount = counter;
                        bestValue = nums[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            int[] result = new int[bestCount];
            for (int i = 0; i < bestCount; i++)
            {
                result[i] = bestValue;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
