namespace BeverageLebel
{
    using System;

    public class BeverageLebel
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            decimal kcal = (decimal)(energy * volume / 100);
            decimal sugarContent = (decimal)(sugar * volume / 100.0);

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {sugarContent}g sugars");
        }
    }
}
