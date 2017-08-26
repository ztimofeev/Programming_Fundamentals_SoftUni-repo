using System;

namespace SweetDessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal banannaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal pricePerSetPortion = 2 * banannaPrice + 4 * eggsPrice + 0.2m * berriesPrice;

            var countSetsPortions = guests / 6;

            if (guests % 6 != 0)
            {
                countSetsPortions++;
            }

            var totalMoneyNeeded = pricePerSetPortion * countSetsPortions;

            if (cash >= totalMoneyNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoneyNeeded:f2}lv.");
            }
            else
            {
                var diff = totalMoneyNeeded - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {diff:f2}lv more.");
            }
        }
    }
}
