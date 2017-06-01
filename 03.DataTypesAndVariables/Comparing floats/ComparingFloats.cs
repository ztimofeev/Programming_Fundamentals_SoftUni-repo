namespace Comparing_floats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());

            double diff = Math.Abs(firstNum - secondNum);
            double eps = 0.000001;

            if (eps > diff)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
