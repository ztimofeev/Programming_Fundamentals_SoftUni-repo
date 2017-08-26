namespace CamelsBack
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var buildings = Console.ReadLine().Split().ToList();
            var cityBase = int.Parse(Console.ReadLine());

            var rounds = (buildings.Count - cityBase) / 2;
            buildings = buildings.Skip(rounds).Take(cityBase).ToList();

            if (rounds != 0)
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
            else
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
        }
    }
}
