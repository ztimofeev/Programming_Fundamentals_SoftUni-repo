namespace DataOverflow
{
    using System;

    public class DataOverflow
    {
        public static void Main()
        {
            var firstNumber = ulong.Parse(Console.ReadLine());
            var secondNumber = ulong.Parse(Console.ReadLine());
            var smaller = firstNumber;
            var bigger = secondNumber;

            if (firstNumber > secondNumber)
            {
                bigger = firstNumber;
                smaller = secondNumber;
            }

            var biggerType = GetType(bigger);
            var smallerType = GetType(smaller);
            var smallerMaxValue = GetSmallerTypeMaxValue(smallerType);
            var countOverflows = Math.Round((double)bigger / smallerMaxValue);

            Console.WriteLine("bigger type: {0}", biggerType);
            Console.WriteLine("smaller type: {0}", smallerType);
            Console.WriteLine("{0} can overflow {1} {2} times", bigger, smallerType, countOverflows);
        }

        public static string GetType(ulong num)
        {
            string type = "";

            if (num <= byte.MaxValue)
            {
                type = "byte";
            }
            else if (num <= ushort.MaxValue)
            {
                type = "ushort";
            }
            else if (num <= uint.MaxValue)
            {
                type = "uint";
            }
            else
            {
                type = "ulong";
            }

            return type;
        }

        public static ulong GetSmallerTypeMaxValue(string type)
        {
            ulong output = 0;
            switch (type)
            {
                case "byte":
                    output = byte.MaxValue;
                    break;
                case "ushort":
                    output = ushort.MaxValue;
                    break;
                case "uint":
                    output = uint.MaxValue;
                    break;
                case "ulong":
                    output = ulong.MaxValue;
                    break;
            }
            return output;
        }
    }
}
