namespace Catch_the_Thief
{
    using System;

    public class CatchTheThief
    {
        public static void Main()
        {
            var typeOfThiefsId = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());

            long maxValue;

            switch (typeOfThiefsId)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                default:
                    maxValue = long.MaxValue;
                    break;
            }

            ulong minDifference = ulong.MaxValue;
            decimal thiefsId = 0;


            for (int i = 0; i < number; i++)
            {
                var currentNumber = long.Parse(Console.ReadLine());

                if (currentNumber <= maxValue)
                {
                    ulong currentDifference = (ulong)(maxValue - currentNumber);

                    if (currentDifference <= minDifference)
                    {
                        minDifference = currentDifference;
                        thiefsId = currentNumber;
                    }
                }
            }

            decimal sentence = 0;

            if (thiefsId > 0)
            {
                sentence = Math.Ceiling(thiefsId / sbyte.MaxValue);
            }
            else if (thiefsId < 0)
            {
                sentence = Math.Ceiling(thiefsId / sbyte.MinValue);
            }

            string period = "years";

            if (sentence == 1)
            {
                period = "year";
            }

            Console.WriteLine($"Prisoner with id {thiefsId} is sentenced to {sentence} {period}");
        }
    }
}
