namespace JumpAround
{
    using System;
    using System.Linq;

    public class JumpAround
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var len = numbers.Length;
            var index = 0;
            var score = 0;
            bool movePossible = true;

            while (movePossible)
            {
                score += numbers[index];
                var rightPosition = index + numbers[index];
                var leftPosition = index - numbers[index];

                if (rightPosition < len)
                {
                    index = rightPosition;
                }
                else if(leftPosition >= 0)
                {
                    index = leftPosition;
                }
                else
                {
                    Console.WriteLine(score);
                    movePossible = false;
                }
            }
        }
    }
}
