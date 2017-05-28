namespace FigureX
{
    using System;

    public class FigureX
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n / 2; i++)
            {
                var leftAndRightEmpty = new string(' ', i - 1);
                var middleEmptyPlaces = new string(' ', n  - i * 2);
                Console.WriteLine(leftAndRightEmpty + "x" + middleEmptyPlaces + "x" + leftAndRightEmpty);
            }

            Console.WriteLine(new string(' ', n / 2) + "x" + new string(' ', n / 2));

            for (int i = n / 2; i > 0; i--)
            {
                var leftAndRightEmpty = new string(' ', i - 1);
                var middleEmptyPlaces = new string(' ', n - 2 * i);
                Console.WriteLine(leftAndRightEmpty + "x" + middleEmptyPlaces + "x" + leftAndRightEmpty);
            }
        }
    }
}
