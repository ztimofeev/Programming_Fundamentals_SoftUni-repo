namespace RestaurantDiscount
{
    using System;

    public class RestaurantDiscount
    {
        public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine().ToLower();

            double price = 0;
            string hallName;

            if (groupSize <= 50)
            {
                hallName = "Small Hall";

                if (package == "normal")
                {
                    price = (2500 + 500) * 0.95 / groupSize;
                }
                else if (package == "gold")
                {
                    price = (2500 + 750) * 0.9 / groupSize;
                }
                else
                {
                    price = (2500 + 1000) * 0.85 / groupSize;
                }
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";

                if (package == "normal")
                {
                    price = (5000 + 500) * 0.95 / groupSize;
                }
                else if (package == "gold")
                {
                    price = (5000 + 750) * 0.9 / groupSize;
                }
                else
                {
                    price = (5000 + 1000) * 0.85 / groupSize;
                }
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";

                if (package == "normal")
                {
                    price = (7500 + 500) * 0.95 / groupSize;
                }
                else if (package == "gold")
                {
                    price = (7500 + 750) * 0.9 / groupSize;
                }
                else
                {
                    price = (7500 + 1000) * 0.85 / groupSize;
                }
            }
            else
            {
                hallName = "something else";
            }

            if (hallName == "something else")
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:f2}$");
            }
        }
    }
}
