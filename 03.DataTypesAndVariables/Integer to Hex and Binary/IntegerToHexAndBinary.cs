namespace Integer_to_Hex_and_Binary
{
    using System;

    public class IntegerToHexAndBinary
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var hex = Convert.ToString(input, 16).ToUpper();
            var binary = Convert.ToString(input, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
