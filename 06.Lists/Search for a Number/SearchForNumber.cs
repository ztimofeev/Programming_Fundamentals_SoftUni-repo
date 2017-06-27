namespace Search_for_a_Number
{
    using System;
    using System.Linq;

    public class SearchForNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var manipulations = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var countToTake = manipulations[0];
            var countToDelete = manipulations[1];
            var numberToFind = manipulations[2];

            bool exist = numbers.Take(countToTake).Skip(countToDelete).Any(n => n == numberToFind);

            if (exist)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
