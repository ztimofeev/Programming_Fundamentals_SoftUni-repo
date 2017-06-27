namespace FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var leftFold = numbers.Take(k).Reverse();
            var rightFold = numbers.Reverse().Take(k);
            var folds = leftFold.Concat(rightFold).ToArray();

            int[] result = new int[k * 2];

            for (int i = 0; i < 2 * k; i++)
            {
                result[i] = numbers[i + k] + folds[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
