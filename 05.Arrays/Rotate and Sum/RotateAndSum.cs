namespace Rotate_and_Sum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rotation = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotation; i++)
            {
                var temp = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = temp;

                for (int x = 0; x < numbers.Length; x++)
                {
                    sum[x] += numbers[x];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
