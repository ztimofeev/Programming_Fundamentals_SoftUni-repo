namespace MagicLetter
{
    using System;

    public class MagicLetter
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char lastChar = char.Parse(Console.ReadLine());
            char skipChar = char.Parse(Console.ReadLine());

            for (char i = firstChar; i <= lastChar; i++)
            {
                for (char j = firstChar; j <= lastChar; j++)
                {
                    for (char x = firstChar; x <= lastChar; x++)
                    {
                        if (i != skipChar && j != skipChar && x != skipChar)
                        {
                            Console.Write($"{i}{j}{x} ");
                        }
                    }
                }
            }
        }
    }
}
