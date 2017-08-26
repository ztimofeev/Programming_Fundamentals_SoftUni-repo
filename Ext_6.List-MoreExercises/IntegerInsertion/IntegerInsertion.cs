namespace IntegerInsertion
{
    using System;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var nextNumber = Console.ReadLine();

            while (nextNumber != "end")
            {
                var indexPlace = nextNumber[0] - '0';
                var digit = int.Parse(nextNumber);
                numbers.Insert(indexPlace, digit);

                nextNumber = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
