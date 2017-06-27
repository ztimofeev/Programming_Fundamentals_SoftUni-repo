namespace Equal_Sums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (nums.Length > 1)
            {
                bool noCase = true;
                for (int i = 0; i < nums.Length; i++)
                {
                    var leftSum = nums.Take(i + 1).Sum();
                    var rightSum = nums.Skip(i).Take(nums.Length).Sum();

                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i);
                        noCase = false;
                        break;
                    }
                }
                if (noCase)
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
