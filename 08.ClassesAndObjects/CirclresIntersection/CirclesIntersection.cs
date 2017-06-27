namespace CirclesIntersection
{
    using System;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstCircleData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point centerOne = new Point
            {
                X = firstCircleData[0],
                Y = firstCircleData[1]
            };

            Circle firstCircle = new Circle
            {
                Center = centerOne,
                Radius = firstCircleData[2]
            };

            var secondCircleData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point centerTwo = new Point
            {
                X = secondCircleData[0],
                Y = secondCircleData[1]
            };

            Circle secondCircle = new Circle
            {
                Center = centerTwo,
                Radius = secondCircleData[2]
            };

            double distanceBetweenCenters = GetDistance(centerOne, centerTwo);

            string result = IsIntersected(firstCircle.Radius, secondCircle.Radius, distanceBetweenCenters);

            Console.WriteLine(result);
        }

        public static double GetDistance(Point first, Point second)
        {
            var diffX = first.X - second.X;
            var diffY = first.Y - second.Y;

            var result = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));

            return result;
        }

        public static string IsIntersected(int radiusOne, int radiusTwo, double distance)
        {
            string result = "Yes";

            if (distance > radiusOne + radiusTwo)
            {
                result = "No";
            }
            return result;
        }
    }
}
