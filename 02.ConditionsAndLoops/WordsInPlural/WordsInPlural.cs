namespace WordsInPlural
{
    using System;

    public class WordsInPlural
    {
        public static void Main()
        {
            var str = Console.ReadLine().ToLower();
            var newStr = string.Empty;

            if (str.EndsWith("y"))
            {
                newStr = str.Remove(str.Length - 1) + "ies";
            }
            else if (str.EndsWith("o") || str.EndsWith("ch") || str.EndsWith("s") || str.EndsWith("sh") || str.EndsWith("x") || str.EndsWith("z"))
            {
                newStr = str + "es";
            }
            else
            {
                newStr = str + "s";
            }

            Console.WriteLine(newStr);
        }
    }
}
