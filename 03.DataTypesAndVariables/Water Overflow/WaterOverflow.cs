namespace Water_Overflow
{
    using System;

    public class WaterOverflow
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());

            int litersInTank = 0;

            for (int i = 0; i < lines; i++)
            {
                var liters = int.Parse(Console.ReadLine());

                if (liters <= (255 - litersInTank))
                {
                    litersInTank += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(litersInTank);
        }
    }
}
