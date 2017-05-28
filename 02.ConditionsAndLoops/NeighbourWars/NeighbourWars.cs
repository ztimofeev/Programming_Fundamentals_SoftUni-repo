namespace NeighbourWars
{
    using System;

    public class NeighbourWars
    {
        public static void Main()
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var round = 0;
            var peshoHealth = 100;
            var goshoHealth = 100;
            string winner = string.Empty;

            do
            {
                round += 1;

                if (round % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                    else
                    {
                        winner = "Pesho";
                        break;
                    }
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                    else
                    {
                        winner = "Gosho";
                        break;
                    }
                }

                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

            } while (peshoHealth > 0 && goshoHealth > 0);

            Console.WriteLine($"{winner} won in {round}th round.");
        }
    }
}
