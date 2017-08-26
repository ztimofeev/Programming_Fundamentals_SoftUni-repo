namespace ValueOfAString
{
    using System;

    public class ValueOfAString
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var letterCase = Console.ReadLine().ToLower();

            int lettersValue = 0;

            switch (letterCase)
            {
                case "uppercase":
                    foreach (var ch in inputString)
                    {
                        if (ch >= 'A' && ch <= 'Z')
                        {
                            lettersValue += ch;
                        }
                    }
                    break;

                case "lowercase":
                    foreach (var ch in inputString)
                    {
                        if (ch >= 'a' && ch <= 'z')
                        {
                            lettersValue += ch;
                        }
                    }
                    break;
            }

            Console.WriteLine($"The total sum is: {lettersValue}");
        }
    }
}
