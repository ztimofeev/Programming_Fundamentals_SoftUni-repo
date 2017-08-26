namespace Placeholders
{
    using System;

    public class Placeholders
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputTokens = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var text = inputTokens[0];
                var words = inputTokens[1].Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";
                    text = text.Replace(currentPlaceholder, words[i]);
                }

                Console.WriteLine(text);

                inputLine = Console.ReadLine();
            }
        }
    }
}
