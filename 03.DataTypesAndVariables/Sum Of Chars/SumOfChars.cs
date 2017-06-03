namespace Sum_Of_Chars
{
    using System;

    public class SumOfChars
    {
        public static void Main()
        {
            var number = byte.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < number; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                sum += letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
