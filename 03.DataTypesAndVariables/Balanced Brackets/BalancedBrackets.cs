namespace Balanced_Brackets
{
    using System;

    public class BalancedBrackets
    {
        public static void Main()
        {
            var iterations = byte.Parse(Console.ReadLine());

            string balance = "BALANCED";
            string previous = String.Empty;

            for (int i = 0; i < iterations; i++)
            {
                var current = Console.ReadLine();

                if (current == "(")
                {
                    if (previous == "(")
                    {
                        balance = "UNBALANCED";
                        break;
                    }

                    previous = "(";
                }

                if (current == ")")
                {
                    if (previous != "(")
                    {
                        balance = "UNBALANCED";
                        break;
                    }

                    previous = ")";
                }
            }

            if (previous == "(")
            {
                balance = "UNBALANCED";
            }

            Console.WriteLine(balance);
        }
    }
}
