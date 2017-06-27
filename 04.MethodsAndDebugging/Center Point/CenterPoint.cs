namespace Center_Point
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            var coorX1 = double.Parse(Console.ReadLine());
            var coorY1 = double.Parse(Console.ReadLine());
            var coorX2 = double.Parse(Console.ReadLine());
            var coorY2 = double.Parse(Console.ReadLine());

            double firstDistance = GetDistanceToPoint(coorX1, coorY1);
            double secondDistance = GetDistanceToPoint(coorX2, coorY2);

            if (firstDistance <= secondDistance)
            {
                Console.WriteLine("({0}, {1})", coorX1, coorY1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", coorX2, coorY2);
            }
        }

        public static double GetDistanceToPoint(double x, double y)
        {
            double dist = Math.Sqrt(x * x + y * y);

            return dist;
        }
    }
}
