namespace TextFilter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            var banWords = Console.ReadLine().Split(new string[]{", "}, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
