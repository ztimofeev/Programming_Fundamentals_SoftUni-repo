namespace Exact_Sum_of_Real_Numbers
{
    using System;

    public class ExactSumOfRealNumbers
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < num; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
