namespace Variable_in_Hex_Format
{
    using System;

    public class VariableInHexFormat
    {
        public static void Main()
        {
            var hex1 = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hex1, 16));
        }
    }
}
