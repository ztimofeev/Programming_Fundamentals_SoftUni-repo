namespace Exchange_Variable_Values
{
    using System;

    public class ExchangeVariableValue
    {
        public static void Main()
        {
            var a = 5;
            var b = 10;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            var temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
