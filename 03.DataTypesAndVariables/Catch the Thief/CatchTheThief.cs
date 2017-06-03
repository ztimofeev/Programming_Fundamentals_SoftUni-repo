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
            string thiefsId = String.Empty;
            

            for (int i = 0; i < number; i++)
            {
                var currentNumber = long.Parse(Console.ReadLine());

                if (currentNumber <= maxValue)
                {
                    ulong currentDifference = (ulong) (maxValue - currentNumber);

                    if (currentDifference <= minDifference)
                    {
                        minDifference = currentDifference;
                        thiefsId = currentNumber.ToString();
                    }
                }
            }

            Console.WriteLine(thiefsId);
        }
    }
}
