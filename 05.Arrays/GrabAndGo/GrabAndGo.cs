namespace GrabAndGo
{
    using System;
    using System.Linq;

    public class GrabAndGo
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var specialNumber = long.Parse(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    index = i;
                }
            }

            if (index > -1)
            {
                var result = numbers.Take(index).Sum();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
