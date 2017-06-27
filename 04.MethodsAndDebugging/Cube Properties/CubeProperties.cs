namespace Cube_Properties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            var sideCube = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    Console.WriteLine("{0:f2}", CubeFaceDiagonal(sideCube));
                    break;
                case "space":
                    Console.WriteLine("{0:f2}", CubeSpaceDiagonal(sideCube));
                    break;
                case "volume":
                    Console.WriteLine("{0:f2}", CubeVolume(sideCube));
                    break;
                case "area":
                    Console.WriteLine("{0:f2}", CubeArea(sideCube));
                    break;
            }
        }

        public static double CubeFaceDiagonal(double side)
        {
            return Math.Sqrt(side * side + side * side);
        }

        public static double CubeSpaceDiagonal(double side)
        {
            var faceDiagonale = Math.Sqrt(side * side + side * side);
            return Math.Sqrt(faceDiagonale * faceDiagonale + side * side);
        }

        public static double CubeVolume(double side)
        {
            return side * side * side;
        }

        public static double CubeArea(double side)
        {
            return 6 * side * side;
        }
    }
}
