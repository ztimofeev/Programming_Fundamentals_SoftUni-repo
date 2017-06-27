namespace Sum_Reversed_Numbers
{
    using System;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var sum = 0;

            foreach (var number in numbers)
            {
                var current = GetReversedNumber(number);
                sum += current;
            }

            Console.WriteLine(sum);
        }

        public static int GetReversedNumber(int n)
        {
            var rev = 0;
            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n = n / 10;
            }
            return rev;
        }
    }
}
