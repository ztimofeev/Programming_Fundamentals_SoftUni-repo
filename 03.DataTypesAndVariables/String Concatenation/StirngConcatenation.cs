namespace String_Concatenation
{
    using System;

    public class StirngConcatenation
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();
            var oddOrEven = Console.ReadLine();
            var iterations = byte.Parse(Console.ReadLine());

            string result = String.Empty;

            for (int i = 1; i <= iterations; i++)
            {
                var word = Console.ReadLine();

                if (oddOrEven == "odd")
                {
                    if (i % 2 == 1)
                    {
                        result += word + delimiter;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        result += word + delimiter;
                    }
                }
            }

            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }
    }
}
