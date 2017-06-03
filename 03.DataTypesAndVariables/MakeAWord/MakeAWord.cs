namespace MakeAWord
{
    using System;

    public class MakeAWord
    {
        public static void Main()
        {
            var n = byte.Parse(Console.ReadLine());

            string word = String.Empty;

            for (int i = 0; i < n; i++)
            {
                var letter = Console.ReadLine();
                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
