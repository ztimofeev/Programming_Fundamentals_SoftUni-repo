namespace CaloriesCounter
{
    using System;

    public class CaloriesCounter
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            var caloriesCounter = 0;

            for (int i = 0; i < n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    caloriesCounter += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    caloriesCounter += 150;
                }
                else if (ingredient == "salami")
                {
                    caloriesCounter += 600;
                }
                else if (ingredient == "pepper")
                {
                    caloriesCounter += 50;
                }
            }

            Console.WriteLine($"Total calories: {caloriesCounter}");
        }
    }
}
