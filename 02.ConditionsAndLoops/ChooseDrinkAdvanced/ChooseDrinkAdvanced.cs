namespace ChooseDrinkAdvanced
{
    using System;

    public class ChooseDrinkAdvanced
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            double totalPrice;

            if (profession == "Athlete")
            {
                totalPrice = quantity * 0.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalPrice = quantity * 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = quantity * 1.70;
            }
            else
            {
                totalPrice = quantity * 1.20;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}

