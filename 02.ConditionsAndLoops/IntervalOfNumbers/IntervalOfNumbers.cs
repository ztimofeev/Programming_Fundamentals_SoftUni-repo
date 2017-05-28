
namespace IntervalOfNumbers
{
    using System;

    public class IntervalOfNumbers
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var startNum = Math.Min(firstNumber, secondNumber);
            var endtNum = Math.Max(firstNumber, secondNumber);

            for (int i = startNum; i <= endtNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
