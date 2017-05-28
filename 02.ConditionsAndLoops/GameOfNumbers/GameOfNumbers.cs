namespace GameOfNumbers
{
    using System;

    public class GameOfNumbers
    {
        public static void Main()
        {
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var firstNumber = 0;
            var secondNumber = 0;
            var combinationCount = 0;
            bool combinationExists = false;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    combinationCount++;

                    if (i + j == magicNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;
                        combinationExists = true;
                    }
                }
            }

            if (combinationExists)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}
