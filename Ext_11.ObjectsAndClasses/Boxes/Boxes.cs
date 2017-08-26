namespace Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var firstDiffPow = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var secondDiffPow = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
            var distance = Math.Sqrt(firstDiffPow + secondDiffPow);
            return distance;
        }
    }

    public class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public double Width => Point.CalculateDistance(UpperLeft, UpperRight);

        public double Heigth => Point.CalculateDistance(UpperLeft, BottomLeft);

        public int CalculatePerimeter(int width, int height)
        {
            return width * 2 + height * 2;
        }

        public int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (inputLine != "end")
            {
                var nextBox = ReadBox(inputLine);
                boxes.Add(nextBox);

                inputLine = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var boxWidth = (int) box.Width;
                var boxHeight = (int) box.Heigth;
                var boxPerimeter = box.CalculatePerimeter(boxWidth, boxHeight);
                var boxArea = box.CalculateArea(boxWidth, boxHeight);

                Console.WriteLine($"Box: {boxWidth}, {boxHeight}");
                Console.WriteLine($"Perimeter: {boxPerimeter}");
                Console.WriteLine($"Area: {boxArea}");
            }
        }

        private static Box ReadBox(string input)
        {
            var tokens = input.Split(new []{" | "}, StringSplitOptions.RemoveEmptyEntries);
            var firstPoint = tokens[0].Split(':').Select(int.Parse).ToArray();
            var secondPoint = tokens[1].Split(':').Select(int.Parse).ToArray();
            var thirdPoint = tokens[2].Split(':').Select(int.Parse).ToArray();
            var fourthPoint = tokens[3].Split(':').Select(int.Parse).ToArray();

            return new Box
            {
                UpperLeft = new Point(firstPoint[0], firstPoint[1]),
                UpperRight = new Point(secondPoint[0], secondPoint[1]),
                BottomLeft = new Point(thirdPoint[0], thirdPoint[1]),
                BottomRight = new Point(fourthPoint[0], fourthPoint[1])
            };
        }
    }
}
