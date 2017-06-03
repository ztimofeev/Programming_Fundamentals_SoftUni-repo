namespace House_Builder
{
    using System;

    public class HouseBuilder
    {
        public static void Main()
        {
            var firstLine = int.Parse(Console.ReadLine());
            var secondLine = int.Parse(Console.ReadLine());

            long intType;
            int sbyteType;

            if (firstLine > secondLine)
            {
                intType = firstLine;
                sbyteType = secondLine;
            }
            else
            {
                intType = secondLine;
                sbyteType = firstLine;
            }

            long totalPrice = 10 * intType + 4 * sbyteType;

            Console.WriteLine(totalPrice);
        }
    }
}
