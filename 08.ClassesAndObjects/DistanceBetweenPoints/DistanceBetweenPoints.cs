namespace DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var dataFirstPoint = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var first = new Point
            {
                X = dataFirstPoint[0],
                Y = dataFirstPoint[1]
            };

            var dataSecondPoint = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var second = new Point
            {
                X = dataSecondPoint[0],
                Y = dataSecondPoint[1]
            };

            var result = CalculateDistance(first, second);

            Console.WriteLine($"{result:f3}");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        } 
    }
}
