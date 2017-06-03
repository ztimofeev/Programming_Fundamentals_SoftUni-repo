namespace TrickyStrings
{
    using System;

    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string output = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string currentWord = Console.ReadLine();
                if (i != n - 1)
                {
                    output = output + currentWord + delimiter;
                }
                else
                {
                    output += currentWord;
                }
            }

            Console.WriteLine(output);
        }
    }
}
