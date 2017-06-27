namespace Longer_Line
{
    using System;

    public class LongerLine
    {
        public static void Main()
        {
            var fx1 = double.Parse(Console.ReadLine());
            var fy1 = double.Parse(Console.ReadLine());
            var fx2 = double.Parse(Console.ReadLine());
            var fy2 = double.Parse(Console.ReadLine());
            var sx1 = double.Parse(Console.ReadLine());
            var sy1 = double.Parse(Console.ReadLine());
            var sx2 = double.Parse(Console.ReadLine());
            var sy2 = double.Parse(Console.ReadLine());

            var firstLength = GetLength(fx1, fy1, fx2, fy2);
            var secondLength = GetLength(sx1, sy1, sx2, sy2);

            if (firstLength >= secondLength)
            {
                var firstDistance = GetDistanceToPoint(fx1, fy1);
                var secondDistance = GetDistanceToPoint(fx2, fy2);

                if (firstDistance <= secondDistance)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", fx1, fy1, fx2, fy2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", fx2, fy2, fx1, fy1);
                }
            }
            else
            {
                var firstDistance = GetDistanceToPoint(sx1, sy1);
                var secondDistance = GetDistanceToPoint(sx2, sy2);

                if (firstDistance <= secondDistance)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", sx1, sy1, sx2, sy2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", sx2, sy2, sx1, sy1);
                }
            }
        }

        public static double GetLength(double x1, double y1, double x2, double y2)
        {
            var xx = Math.Abs(x1 - x2);
            var yy = Math.Abs(y1 - y2);

            return Math.Sqrt(xx * xx + yy * yy);
        }

        public static double GetDistanceToPoint(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
