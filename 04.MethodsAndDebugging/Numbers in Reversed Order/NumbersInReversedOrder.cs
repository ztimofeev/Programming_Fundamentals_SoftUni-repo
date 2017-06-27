namespace Numbers_in_Reversed_Order
{
    using System;

    public class NumbersInReversedOrder
    {
        public static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNumber(number));

        }

        public static string ReversedNumber(decimal num)
        {
            var input = num.ToString();
            string reversed = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            return reversed;
        }
    }
}
