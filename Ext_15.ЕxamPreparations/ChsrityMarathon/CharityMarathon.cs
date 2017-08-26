using System;

namespace CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            long lapLenght = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            long maxRunners;

            if (trackCapacity * days >= runners)
            {
                maxRunners = runners;
            }
            else
            {
                maxRunners = trackCapacity * days;
            }

            var totalKm = (maxRunners * laps * lapLenght) / 1000;

            double totalMoney = totalKm * moneyPerKm;
            Console.WriteLine("Money raised: {0:F2}", totalMoney);
        }
    }
}
