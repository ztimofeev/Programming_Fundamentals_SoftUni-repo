namespace ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    };

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPointParts = Console.ReadLine().Split().Select(double.Parse).ToArray();

                var currentPoint = new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                };

                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointMin = points[i];
                        secondPointMin = points[j];
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");
        }

        public static double CalculateDistance(Point first, Point second)
        {
            var diffX = first.X - second.X;
            var diffY = first.Y - second.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
