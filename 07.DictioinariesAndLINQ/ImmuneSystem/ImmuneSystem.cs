namespace ImmuneSystem
{
    using System;
    using System.Collections.Generic;

    public class ImmuneSystem
    {
        public static void Main()
        {
            var health = double.Parse(Console.ReadLine());
            var initialHealth = health;

            var virus = Console.ReadLine();
            bool isImSystCrashed = false;
            List<string> encounteredViruses = new List<string>();

            while (virus != "end")
            {
                var virusStrength = GetVirusStrength(virus);
                int defeatTime;

                if (!encounteredViruses.Contains(virus))
                {
                    defeatTime = virusStrength * virus.Length;
                    encounteredViruses.Add(virus);
                }
                else
                {
                    defeatTime = virusStrength * virus.Length / 3;
                }

                if (health > defeatTime)
                {
                    health -= defeatTime;
                }
                else
                {
                    Console.WriteLine($"Virus {virus}: {virusStrength} => {defeatTime} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    isImSystCrashed = true;
                    break;
                }

                PrintCurrentState(virus, virusStrength, defeatTime, health);

                health = Math.Floor(health * 1.2);

                if (health > initialHealth)
                {
                    health = initialHealth;
                }

                virus = Console.ReadLine();
            }

            if (! isImSystCrashed)
            {
                Console.WriteLine($"Final Health: {health}");
            }
        }

        private static void PrintCurrentState(string virus, int virusStrength, int defeatTime, double health)
        {
            var defeatTimeMinute = defeatTime / 60;
            var defeatTimeSeconds = defeatTime % 60;
            Console.WriteLine($"Virus {virus}: {virusStrength} => {defeatTime} seconds");
            Console.WriteLine($"{virus} defeated in {defeatTimeMinute}m {defeatTimeSeconds}s.");
            Console.WriteLine($"Remaining health: {health}");
        }

        private static int GetVirusStrength(string virus)
        {
            int virNameInNumber = 0;

            foreach (var symbol in virus)
            {
                virNameInNumber += symbol;
            } 
            return virNameInNumber / 3;
        }
    }
}
