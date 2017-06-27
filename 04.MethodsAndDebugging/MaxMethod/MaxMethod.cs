namespace MaxMethod
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            var maxNumber = GetMax(GetMax(firstNum, secondNum), thirdNum);

            Console.WriteLine(maxNumber);
        }

        public static int GetMax(int first, int second)
        {
            var bigger = 0;
            if (first > second)
            {
                bigger = first;
            }
            else
            {
                bigger = second;
            }

            return bigger;
        }
    }
}
