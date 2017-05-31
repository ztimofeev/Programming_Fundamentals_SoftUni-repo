namespace SpecialNumbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var digits = i;
                var sum = 0;

                while (digits > 0)
                {
                    sum += digits % 10;
                    digits /= 10;
                }

                bool specialNumber = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {specialNumber}");
            }
        }
    }
}
